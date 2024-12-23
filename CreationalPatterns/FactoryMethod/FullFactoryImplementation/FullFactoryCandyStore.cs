namespace FactoryMethod;

public abstract class FullFactoryCandyStore
{
    public void SellCandy()
    {
        var candy = GetCandy();
        Console.WriteLine($"Sold {candy.Name()} of {candy.Sweetness()}: sweetness\n");
    }

    public abstract Candy GetCandy();
}
