using AbstractDesignPattern.AbstractFactory;
using AbstractDesignPattern.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern.ConcreteFactories.Factory
{
    class ComputerFactoriesFactory
    {
        public static IComputerFactory CreateComputerFactory(Computers computer)
        {
            IComputerFactory computerFactory = computer switch
            {
                Computers.Acer => new AcerFactory(),
                Computers.Asus => new AsusFactory(),
                Computers.Lenovo => new LenovoFactory()
            };
            return computerFactory;
        }
    }
}
