using AbstractFactoryDesignPatternExample.Database.Abstract;
using AbstractFactoryDesignPatternExample.Database.Concrete;
using AbstractFactoryDesignPatternExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternExample.Database.Factory
{
    internal class DatabaseCreator
    {
        AbstractCommand _command;
        AbstractConnection _connection;

        public Database CreateDatabase(AbstractDatabaseFactory databaseFactory)
        {
            _command = databaseFactory.CreateCommand();
            _connection = databaseFactory.CreateConnection();
            string typeName = databaseFactory.GetType().Name.Replace("_Factory", "");
            var type = Enum.Parse(typeof(DatabaseType), typeName);
            return new((DatabaseType)type, _connection, _command);
        }
    }
}
