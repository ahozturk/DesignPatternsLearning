using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternExample.Database.Abstract
{
    internal abstract class AbstractCommand
    {
        public abstract void Execute(string command);
    }
}
