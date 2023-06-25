var example1 = Example.GetInstance;
var example2 = Example.GetInstance;
var example3 = Example.GetInstance;
var example4 = Example.GetInstance;
example1.Counter += 1;
example2.Counter += 1;
example3.Counter += 1;
example4.Counter += 1;
Console.WriteLine(example4.Counter);

class Example
{
    public int Counter { get; set; }
    private Example() => Console.WriteLine("Created!"); 
    static Example() => GetInstance = new Example();

    public static Example GetInstance;
    
    //public static Example GetInstance()
    //{
    //    if (Instance == null)
    //        Instance = new();
    //    return Instance;
    //}
}