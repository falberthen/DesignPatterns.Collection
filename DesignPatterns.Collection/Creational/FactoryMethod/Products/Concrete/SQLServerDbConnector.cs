using DesignPatterns.Creational.FactoryMethod.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod.Products.Concrete
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class SqlServerDbConnector : DbConnector
    {
        public SqlServerDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Connecting to Oracle...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
