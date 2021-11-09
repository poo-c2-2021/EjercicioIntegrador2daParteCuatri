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

        public static List<string> TraerDatos()
        {
            List<string> auxLista = new List<string>();

            comando.CommandText = "Select * from  Plantas";









            return auxLista;
        }







    }
}
