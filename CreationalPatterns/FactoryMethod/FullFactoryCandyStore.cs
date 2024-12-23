namespace FactoryMethod;

public abstract class FullFactoryCandyStore
{
    public void SellCandy()
    {
        var candy = GetCandy();
        Console.WriteLine($"{candy.Name()} is Sold\n");
    }

    public abstract Candy GetCandy();
}
