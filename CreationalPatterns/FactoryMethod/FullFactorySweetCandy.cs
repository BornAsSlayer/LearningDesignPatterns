namespace FactoryMethod;

public class FullFactorySweetCandy : FullFactoryCandyStore
{
    public override Candy GetCandy()
    {
        return new SweetCandy();
    }
}
