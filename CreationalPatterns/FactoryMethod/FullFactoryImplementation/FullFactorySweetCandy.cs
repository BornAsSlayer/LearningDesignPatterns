namespace FactoryMethod;

public class FullFactorySweetCandyStore : FullFactoryCandyStore
{
    public override Candy GetCandy()
    {
        return new SweetCandy();
    }
}
