Console.WriteLine("Hello, World!");

var instance = ProductCreator.GetInstance(ProductType.CProduct);
Console.WriteLine();

public interface IProduct
{
    int Id { get; set; }
    string Name { get; set; }
}
public class AProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public AProduct(string name)
    {
        Name = name;
    }
}
public class BProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public BProduct(string name)
    {
        Name = name;
    }
}
public class CProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CProduct(string name)
    {
        Name = name;
    }
}

public interface IFactory
{
    IProduct GetInstance();
}
public class AFactory : IFactory
{
    public IProduct GetInstance()
    {
        return new AProduct("Example");
    }
}
public class BFactory : IFactory
{
    public IProduct GetInstance()
    {
        return new BProduct("Example");
    }
}
public class CFactory : IFactory
{
    public IProduct GetInstance()
    {
        return new CProduct("Example");
    }
}

public enum ProductType
{
    AProduct,
    BProduct,
    CProduct
}
public class ProductCreator
{
    public static IProduct GetInstance(ProductType productType)
    {
        IFactory factory = productType switch
        {
            ProductType.AProduct => new AFactory(),
            ProductType.BProduct => new BFactory(),
            ProductType.CProduct => new CFactory()
        };
        return factory.GetInstance();
    }
}