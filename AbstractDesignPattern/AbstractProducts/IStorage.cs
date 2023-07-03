using AbstractDesignPattern.ValueObjects;

namespace AbstractDesignPattern.AbstractProducts
{
    interface IStorage
    {
        Capacity Capacity { get; set; }
    }
}
