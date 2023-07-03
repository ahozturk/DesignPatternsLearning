using AbstractDesignPattern.AbstractProducts;

namespace AbstractDesignPattern.AbstractFactory
{
    interface IComputerFactory
    {
        ICPU CreateCPU();
        IGPU CreateGPU();
        IRAM CreateRAM();
        IStorage CreateStorage();
    }
}
