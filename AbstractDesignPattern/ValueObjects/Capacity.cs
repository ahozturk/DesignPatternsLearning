using AbstractDesignPattern.Enums;

namespace AbstractDesignPattern.ValueObjects
{
    class Capacity
    {
        public Capacity(int size, FileSizeTypes sizeType)
        {
            Size = size;
            SizeType = sizeType;
        }

        public int Size { get; set; }
        public FileSizeTypes SizeType { get; set; }
    }
}