namespace FactoryMethod.AbstractFactoryImplementation;

public class AbstractFactorySourCandyStore : AbstractFactoryCandyStore
{
    public override Candy GetCandy()
    {
        return new SourCandy();
    }

    public override IWrapper GetWrapper()
    {
        return new PlasticWrapper();
    }
}
