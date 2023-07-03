using AbstractDesignPattern.AbstractFactory;
using AbstractDesignPattern.AbstractProducts;
using AbstractDesignPattern.ConcreteProducts;
using AbstractDesignPattern.Enums;
using AbstractDesignPattern.ValueObjects;

namespace AbstractDesignPattern.ConcreteFactories
{
    class LenovoFactory : IComputerFactory
    {
        public ICPU CreateCPU() => new CPU("Intel", 12);
        public IGPU CreateGPU() => new GPU("NVidia", new Capacity(4, FileSizeTypes.GB));
        public IRAM CreateRAM() => new RAM(new Capacity(16, FileSizeTypes.GB), 2400);
        public IStorage CreateStorage() => new Storage(new Capacity(1, FileSizeTypes.TB));
    }
}
