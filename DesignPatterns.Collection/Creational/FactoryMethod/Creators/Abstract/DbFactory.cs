using DesignPatterns.Creational.FactoryMethod.Creators.Concrete;
using DesignPatterns.Creational.FactoryMethod.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod.Creators.Abstract
{
    /// <summary>
    /// Abstract Creator
    /// </summary>
    public abstract class DbFactory
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public abstract DbConnector CreateConnector(string connectionString);

        /// <summary>
        /// Database type selector
        /// </summary>
        /// <param name="dataBase"></param>
        /// <returns></returns>
        public static DbFactory Database(DataBase dataBase)
        {
            if (dataBase == DataBase.SqlServer)
                return new SqlFactory();
            if (dataBase == DataBase.Oracle)
                return new OracleFactory();

            throw new ApplicationException("Not implemented database.");
        }
    }
}
