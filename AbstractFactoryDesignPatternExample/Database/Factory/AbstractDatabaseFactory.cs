using AbstractFactoryDesignPatternExample.Database.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternExample.Database.Factory
{
    internal abstract class AbstractDatabaseFactory
    {
        public abstract AbstractCommand CreateCommand();
        public abstract AbstractConnection CreateConnection();

    }
}
