using AbstractDesignPattern.ValueObjects;

namespace AbstractDesignPattern.AbstractProducts
{
    interface IRAM
    {
        Capacity MemoryCapacity { get; set; }

        int Frequency { get; set; }
    }
}
