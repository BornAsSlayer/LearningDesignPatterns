namespace FactoryMethod.AbstractFactoryImplementation;

public abstract class AbstractFactoryCandyStore
{
    public void SellCandy()
    {
        var candy = GetCandy();
        var wrapper = GetWrapper();

        Console.WriteLine($"Sold {candy.Name()} of {candy.Sweetness()}: sweetness in a {wrapper.GetWrapper()}\n");
    }    

    public abstract Candy GetCandy();

    public abstract IWrapper GetWrapper();
}
