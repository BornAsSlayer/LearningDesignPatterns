namespace FactoryMethod;

public class SimpleCandyStore
{
    public void SellCandy(string candyType)
    {
        var candy = SimpleCandyFactory.GetCandy(candyType);
        Console.WriteLine($"Sold {candy.Name()} of {candy.Sweetness()}: sweetness\n");
    }
}
