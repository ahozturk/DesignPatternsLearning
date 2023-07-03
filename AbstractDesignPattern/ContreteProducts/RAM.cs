using AbstractDesignPattern.AbstractProducts;
using AbstractDesignPattern.ValueObjects;

namespace AbstractDesignPattern.ConcreteProducts
{

    class RAM : IRAM
    {
        public RAM(Capacity memoryCapacity, int frequency)
        {
            MemoryCapacity = memoryCapacity;
            Frequency = frequency;
        }

        public Capacity MemoryCapacity { get; set; }
        public int Frequency { get; set; }
    }

}