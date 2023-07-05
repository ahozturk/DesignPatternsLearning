using AbstractFactoryDesignPatternExample.Database.Abstract;
using AbstractFactoryDesignPatternExample.Database.Concrete;
using AbstractFactoryDesignPatternExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternExample.Database
{
    internal class Database
    {
        public Database(DatabaseType type, AbstractConnection connection, AbstractCommand command)
        {
            Type = type;
            Connection = connection;
            Command = command;
        }

        public DatabaseType Type { get; set; }
        public AbstractConnection Connection { get; set; }
        public AbstractCommand Command { get; set; }
    }
}
