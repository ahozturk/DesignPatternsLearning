using AbstractDesignPattern.AbstractProducts;

namespace AbstractDesignPattern.ConcreteProducts
{

    class CPU : ICPU
    {
        public CPU(string brand, int coreCount)
        {
            Brand = brand;
            CoreCount = coreCount;
        }

        public string Brand { get; set; }
        public int CoreCount { get; set; }
    }

}
