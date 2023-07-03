using AbstractDesignPattern.Creator;
using AbstractDesignPattern.Entities;
using AbstractDesignPattern.Enums;
Console.WriteLine("Selam");


ComputerCreator computerCreator = new();
Computer asus = computerCreator.CreateComputer(Computers.Asus);
Computer acer = computerCreator.CreateComputer(Computers.Acer);
Computer lenovo= computerCreator.CreateComputer(Computers.Lenovo);

Console.WriteLine();