using AbstractFactoryDesignPatternExample.Database.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternExample.Database.Concrete
{
    internal class Command : AbstractCommand
    {
        public override void Execute(string command)
        {
            //Command Executing...
        }
    }
}
