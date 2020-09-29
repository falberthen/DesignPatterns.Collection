using DesignPatterns.Creational.FactoryMethod.Creators.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    /// <summary>
    /// This class was designed to demonstrate 
    /// the usage of FactoryMethod pattern
    /// </summary>
    public class FactoryMethodTest
    {
        private const string connstring = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

        public static void Execute()
        {
            string sqlServerCommand = "SELECT * FROM SQL_TABLE";
            string oracleSqlCommand = "SELECT * FROM ORACLE_TABLE";

            var sqlServerConn = DbFactory.Database(DataBase.SqlServer)
                                .CreateConnector(connstring)
                                .Connect();

            sqlServerConn.ExecuteCommand(sqlServerCommand);
            sqlServerConn.Close();

            Console.WriteLine("\n--------------------------------\n");

            var oracleConn = DbFactory.Database(DataBase.Oracle)
                                .CreateConnector(connstring)
                                .Connect();

            oracleConn.ExecuteCommand(oracleSqlCommand);
            oracleConn.Close();
        }
    }
}
