namespace FactoryMethod;

public class FullFactorySourCandyStore : FullFactoryCandyStore
{
    public override Candy GetCandy()
    {
        return new SourCandy();
    }
}
