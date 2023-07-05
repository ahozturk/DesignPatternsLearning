using AbstractFactoryDesignPatternExample.Database.Abstract;
using AbstractFactoryDesignPatternExample.Database.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternExample.Database.Factory.ConcreteFactories
{
    internal class MYSQL_Factory : AbstractDatabaseFactory
    {
        public override AbstractCommand CreateCommand()
        {
            var command = new Command();
            return command;
        }

        public override AbstractConnection CreateConnection()
        {
            var connection = new Connection("mysql connection string");
            return connection;
        }
    }
}
