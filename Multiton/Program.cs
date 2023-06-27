// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a = Task.Run(() =>
{
    Database.GetInstance("MySQL");
});
var a2 = Task.Run(() =>
{
    Database.GetInstance("MySQL");
});

await Task.WhenAll(a, a2);

Database.GetInstance("MySQL");
Database.GetInstance("MySQL");
class Database
{
    Database()
    {
        Console.WriteLine($"{nameof(Database)} Created!");
    }

    static Dictionary<string, Database> Instances = new();
    static object _obj = new();
    public static Database GetInstance(string key)
    {
        lock (_obj)
        {

            if (!Instances.ContainsKey(key))
                Instances[key] = new Database();
            return Instances[key];
        }
    }
}