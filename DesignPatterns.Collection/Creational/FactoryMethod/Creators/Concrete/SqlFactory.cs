using DesignPatterns.Creational.FactoryMethod.Creators.Abstract;
using DesignPatterns.Creational.FactoryMethod.Products.Abstract;
using DesignPatterns.Creational.FactoryMethod.Products.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod.Creators.Concrete
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class SqlFactory : DbFactory
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerDbConnector(connectionString);
        }
    }
}
