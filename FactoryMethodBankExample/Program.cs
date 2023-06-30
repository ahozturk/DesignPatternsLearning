// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var vakifBank = BankFactory.GetInstance(Banks.VakifBank) as VakifBank;
var isBankasi = BankFactory.GetInstance(Banks.IsBankasi) as IsBankasi;
Console.WriteLine();

public interface IBank
{

}
public record AkbankAccessInfo
{
    public string AccessKey { get; set; }
}
public class Akbank : IBank
{
    public Akbank(AkbankAccessInfo akbankAccessInfo)
    {
        //Open Connection with Akbank Service
        Console.WriteLine($"Opening Connection Key: {akbankAccessInfo.AccessKey} Akbank...");
        //if access key is valid
        Console.WriteLine("Successfully connected Akbank");
    }
    static Akbank Instance { get; }
    static Akbank()
    {
        Instance = new Akbank(new AkbankAccessInfo()
        {
            AccessKey = "57rT9Kp2D1vN"
        });
    }
    public static Akbank GetInstance() => Instance;

}
public class VakifBank : IBank
{
    public VakifBank(string userName, string password)
    {
        //Open Connection with Akbank Service
        Console.WriteLine($"UserName: {userName} and pwd: {password} Opening Connection VakifBank...");
        //if userName and password is valid
        Console.WriteLine("Successfully connected VakifBank");
    }

    static VakifBank Instance { get; }
    static VakifBank()
    {
        Instance = new VakifBank("api4", " R#d8$P7@wD!");
    }
    public static VakifBank GetInstance() => Instance;
}
public class IsBankasi : IBank
{
    private string Key { get; }
    private string Password { get; }
    public IsBankasi(string accessKey, string password)
    {
        Key = accessKey;
        Password = password;
    }

    public void ConnectToService()
    {
        Console.WriteLine($"Connecting to IsBankasi Service key: {Key} - pwd: {Password}");
    }

    static IsBankasi Instance { get; }
    static IsBankasi()
    {
        Instance = new IsBankasi("a4j7s9G2k5L8p", "X6n3B9q8R2m5V");
    }
    public static IsBankasi GetInstance() => Instance;
}

public interface IBankFactory
{
    IBank GetInstance();
}
public class AkbankFactory : IBankFactory
{
    AkbankFactory() { }
    public IBank GetInstance()
    {
        return Akbank.GetInstance();
    }

    static AkbankFactory Instance { get; }
    static AkbankFactory()
    {
        Instance = new();
    }
    public static IBankFactory GetFactoryInstance() => Instance;
}
public class VakifBankFactory : IBankFactory
{
    VakifBankFactory() { }
    public IBank GetInstance()
    {
        return VakifBank.GetInstance();
    }
    static VakifBankFactory Instance { get; }
    static VakifBankFactory()
    {
        Instance = new();
    }
    public static IBankFactory GetFactoryInstance() => Instance;

}
public class IsBankasiFactory : IBankFactory
{
    IsBankasiFactory() { }
    public IBank GetInstance()
    {
        var instance = IsBankasi.GetInstance();
        instance.ConnectToService();
        return instance;
    }

    static IsBankasiFactory Instance { get; }
    static IsBankasiFactory()
    {
        Instance = new();
    }
    public static IBankFactory GetFactoryInstance() => Instance;
}

public class BankFactory
{
    public static IBank GetInstance(Banks banks)
    {
        IBankFactory bankFactory = banks switch
        {
            Banks.Akbank => AkbankFactory.GetFactoryInstance(),
            Banks.VakifBank => VakifBankFactory.GetFactoryInstance(),
            Banks.IsBankasi => IsBankasiFactory.GetFactoryInstance()
        };
        return bankFactory.GetInstance();
    }
}
public enum Banks
{
    Akbank,
    VakifBank,
    IsBankasi
}