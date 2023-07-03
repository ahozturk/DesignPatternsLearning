using AbstractDesignPattern.ValueObjects;

namespace AbstractDesignPattern.AbstractProducts
{
    interface IGPU
    {
        string Brand { get; set; }
        Capacity VRAM { get; set; }
    }
}
