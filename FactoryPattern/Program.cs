Console.WriteLine("Hello, World!");

IProduct product1 = new AProduct("Example");
IProduct product2 = ProductCreator.GetInstance(ProductType.AProduct);

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
        switch (productType)
        {
            case ProductType.AProduct:
                return new AProduct("Example");
            case ProductType.BProduct:
                return new BProduct("Example");
            case ProductType.CProduct:
                return new CProduct("Example");
            default:
                break;
        }
        throw new Exception();
    }
}