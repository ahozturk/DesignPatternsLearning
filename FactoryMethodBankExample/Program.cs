// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var vakifBank =  BankFactory.GetInstance(Banks.VakifBank) as VakifBank;
var isBankasi=  BankFactory.GetInstance(Banks.IsBankasi) as IsBankasi;
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
}


public interface IBankFactory
{
    IBank GetInstance();
}
public class AkbankFactory : IBankFactory
{
    public IBank GetInstance()
    {
        return new Akbank(new AkbankAccessInfo()
        {
            AccessKey = "57rT9Kp2D1vN"
        });
    }
}
public class VakifBankFactory : IBankFactory
{
    public IBank GetInstance()
    {
        return new VakifBank("api4", " R#d8$P7@wD!");
    }
}
public class IsBankasiFactory : IBankFactory
{
    public IBank GetInstance()
    {
        var instance = new IsBankasi("a4j7s9G2k5L8p", "X6n3B9q8R2m5V");
        instance.ConnectToService();
        return instance;
    }
}

public class BankFactory
{
    public static IBank GetInstance(Banks banks)
    {
        IBankFactory bankFactory = banks switch
        {
            Banks.Akbank => new AkbankFactory(),
            Banks.VakifBank => new VakifBankFactory(),
            Banks.IsBankasi => new IsBankasiFactory()
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