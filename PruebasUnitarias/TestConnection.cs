using System;
using System.Data;
using Datos;
using MySql.Data.MySqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestConnection
    {
        [TestMethod]
        public void ModelConnection()
        {
            ModelConnection connection = new ModelConnection();
            Assert.IsTrue(connection.connection.State == ConnectionState.Open);
        }
        [TestMethod]
        public void setConnectionData()
        {
            ModelConnection connection = new ModelConnection();
            string dbUser = "testUser";
            string dbPort = "testPort";
            string dbPassword = "testPassword";
            connection.setConnectionData(dbUser, dbPort, dbPassword);
            Assert.IsTrue(connection.dbUser == "testUser" && connection.dbPort == "testPort" && connection.dbPassword == "testPassword");
            connection.setDefaultConnection();
        }
    }
}
