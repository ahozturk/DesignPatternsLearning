using AbstractDesignPattern.AbstractFactory;
using AbstractDesignPattern.AbstractProducts;
using AbstractDesignPattern.ConcreteProducts;
using AbstractDesignPattern.Entities;
using AbstractDesignPattern.Enums;
using AbstractDesignPattern.ConcreteFactories;

namespace AbstractDesignPattern.Creator
{

    class ComputerCreator
    {
        ICPU Processor;
        IGPU GraphicCard;
        IRAM Memory;
        IStorage Storage;

        public Computer CreateComputer(Computers computer)
        {
            IComputerFactory computerFactory = computer switch
            {
                Computers.Acer => new AcerFactory(),
                Computers.Asus => new AsusFactory(),
                Computers.Lenovo => new LenovoFactory()
            };
            Processor = computerFactory.CreateCPU();
            GraphicCard = computerFactory.CreateGPU();
            Memory = computerFactory.CreateRAM();
            Storage = computerFactory.CreateStorage();
            return new(Processor as CPU, GraphicCard as GPU, Memory as RAM, Storage as Storage);
        }
    }
}
