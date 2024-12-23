namespace FactoryMethod;

public class FullFactorySourCandy : FullFactoryCandyStore
{
    public override Candy GetCandy()
    {
        return new SourCandy();
    }
}
