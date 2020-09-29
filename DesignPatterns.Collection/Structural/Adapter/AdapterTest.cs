using DesignPatterns.Structural.Adapter.Adaptee;
using DesignPatterns.Structural.Adapter.Adapter;
using DesignPatterns.Structural.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class AdapterTest
    {
        public static void Execute()
        {
            var standardLog = new TransactionService(new Logger());
            standardLog.LogTransation();

            var dbLog = new TransactionService(new LogAdapter(new LogDbService()));
            dbLog.LogTransation();
        }
    }
}
