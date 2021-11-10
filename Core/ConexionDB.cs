using System;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace Core
{
    public static class ConexionDB
    {

        static SqlConnection conexion; // se conecta a la instancia sql
        static SqlCommand comando;  // llevar la consulta
        static SqlDataReader reader; // devolverme los datos 

        static ConexionDB()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-JSBRMN8;Database=Lucas;Trusted_Connection=True;");


            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

        }

        public static List<string> TraerDatos(string query)
        {
            try
            {
                List<string> auxLista = new List<string>();
                //0   
                comando.CommandText = query;

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    auxLista.Add(reader[0].ToString());
                }

                return auxLista;
            }
            catch (Exception ex)
            {
                // LOG
                // INSERTES EL ERROR EN LA BASE DE DATOS 

                throw;
            }

            finally
            {
                conexion.Close();
            }
        }
        public static List<Pato> TraerDatosDelPato(string query)
        {
            try
            {
                List<Pato> auxLista = new List<Pato>();
                //0   
                comando.CommandText = query;

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    auxLista.Add(new Pato(
                                            int.Parse(reader[0].ToString()),
                                            reader[1].ToString(),
                                            reader[2].ToString()
                                            ));
                }

                return auxLista;
            }
            catch (Exception ex)
            {
                // LOG
                // INSERTES EL ERROR EN LA BASE DE DATOS 

                throw;
            }

            finally
            {
                conexion.Close();
            }
        }
        public static void Insertar(string nombre, string direccion)
        {
            try
            {
                List<string> auxLista = new List<string>();

                comando.CommandText = "Insert into Usuarios values (@Nombre, @Dire ) ";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Dire", direccion);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // LOG
                // INSERTES EL ERROR EN LA BASE DE DATOS 

                throw;
            }

            finally
            {
                conexion.Close();
            }

        }







    }
}
