using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod.Products.Abstract
{
    /// <summary>
    /// Abstract Product
    /// </summary>
    public abstract class DbConnector
    {
        public abstract Connection Connect();

        protected string ConnectionString { get; set; }

        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
