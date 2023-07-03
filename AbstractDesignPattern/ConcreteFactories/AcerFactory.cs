using AbstractDesignPattern.AbstractFactory;
using AbstractDesignPattern.AbstractProducts;
using AbstractDesignPattern.ConcreteProducts;
using AbstractDesignPattern.Enums;

namespace AbstractDesignPattern.ConcreteFactories
{
    internal class AcerFactory : IComputerFactory
    {
        public ICPU CreateCPU() => new CPU("Intel", 4);
        public IGPU CreateGPU() => new GPU("AMD", new(2, FileSizeTypes.GB));
        public IRAM CreateRAM() => new RAM(new(4, FileSizeTypes.GB), 2133);
        public IStorage CreateStorage() => new Storage(new(512, FileSizeTypes.GB));
    }
}
