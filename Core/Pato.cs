using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Pato
    {
        int id;
        string nombre;
        string dire;

        public Pato(int id, string nombre, string dire)
        {
            this.id = id;
            this.nombre = nombre;
            this.dire = dire;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dire { get => dire; set => dire = value; }
    }
}
