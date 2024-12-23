namespace FactoryMethod;

public class SimpleCandyStore
{
    public void SellCandy(string candyType)
    {
        var candy = SimpleCandyFactory.GetCandy(candyType);
        Console.WriteLine($"{candy.Name} is Sold\n");
    }
}
