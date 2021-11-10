using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestearConsulta()
        {
            List<string> aux = ConexionDB.TraerDatos("Select * from Usuarios");

            Assert.IsTrue(aux.Count > 0);

        }

        [TestMethod]
        public void TestearInsert()
        {
            string nombre = "Pepe";
            ConexionDB.Insertar(nombre, "Calle ruf");
            List<string> aux = ConexionDB.TraerDatos("Select top(1) nombre from Usuarios order by id desc");

            nombre = "Juana";
            ConexionDB.Insertar(nombre, "Calle ruf");
            aux = ConexionDB.TraerDatos("Select top(1) nombre from Usuarios order by id desc");

            Assert.AreEqual(nombre, aux[0]);
        }
    }
}
