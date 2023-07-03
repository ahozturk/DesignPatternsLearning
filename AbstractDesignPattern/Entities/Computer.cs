using AbstractDesignPattern.ConcreteProducts;

namespace AbstractDesignPattern.Entities
{
    class Computer
    {
        public Computer(CPU processor, GPU graphicCard, RAM memory, Storage storage)
        {
            Processor = processor;
            GraphicCard = graphicCard;
            Memory = memory;
            Storage = storage;
        }

        public CPU Processor { get; set; }
        public GPU GraphicCard { get; set; }
        public RAM Memory { get; set; }
        public Storage Storage { get; set; }
    }
}