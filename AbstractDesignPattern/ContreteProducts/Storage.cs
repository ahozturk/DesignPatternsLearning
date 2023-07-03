using AbstractDesignPattern.AbstractProducts;
using AbstractDesignPattern.ValueObjects;

namespace AbstractDesignPattern.ConcreteProducts
{
    class Storage : IStorage
    {
        public Capacity Capacity { get; set; }

        public Storage(Capacity capacity)
        {
            Capacity = capacity;
        }
    }
}
