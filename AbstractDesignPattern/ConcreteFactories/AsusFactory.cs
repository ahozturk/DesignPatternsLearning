using AbstractDesignPattern.AbstractFactory;
using AbstractDesignPattern.AbstractProducts;
using AbstractDesignPattern.ConcreteProducts;
using AbstractDesignPattern.Enums;
using AbstractDesignPattern.ValueObjects;

namespace AbstractDesignPattern.ConcreteFactories
{
    class AsusFactory : IComputerFactory
    {
        public ICPU CreateCPU() => new CPU("AMD", 8);
        public IGPU CreateGPU() => new GPU("AMD Radeon", new Capacity(4, FileSizeTypes.GB));
        public IRAM CreateRAM() => new RAM(new Capacity(8, FileSizeTypes.GB), 3200);
        public IStorage CreateStorage() => new Storage(new Capacity(512, FileSizeTypes.GB));
    }
}
