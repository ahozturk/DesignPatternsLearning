using AbstractFactoryDesignPatternExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternExample.Database.Abstract
{
    internal abstract class AbstractConnection
    {
        public abstract string ConnectionString { get; set;  }
        public abstract ConnectionState State { get; set;  }
        public abstract bool Connect();
        public abstract bool Disconnect();
    }
}
