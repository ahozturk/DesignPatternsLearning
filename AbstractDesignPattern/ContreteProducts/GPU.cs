using AbstractDesignPattern.AbstractProducts;
using AbstractDesignPattern.ValueObjects;

namespace AbstractDesignPattern.ConcreteProducts
{

    class GPU : IGPU
    {
        public GPU(string brand, Capacity VRAM)
        {
            Brand = brand;
            this.VRAM = VRAM;
        }

        public string Brand { get; set; }
        public Capacity VRAM { get; set; }
    }
}
