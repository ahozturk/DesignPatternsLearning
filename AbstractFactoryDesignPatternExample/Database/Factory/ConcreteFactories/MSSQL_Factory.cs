using AbstractFactoryDesignPatternExample.Database.Abstract;
using AbstractFactoryDesignPatternExample.Database.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternExample.Database.Factory.ConcreteFactories
{
    internal class MSSQL_Factory : AbstractDatabaseFactory
    {
        public override AbstractCommand CreateCommand()
        {
            var command = new Command();
            return command;
        }

        public override AbstractConnection CreateConnection()
        {
            var connection = new Connection("mssql connection string");
            return connection;
        }
    }
}
