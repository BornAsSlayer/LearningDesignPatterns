namespace FactoryMethod.AbstractFactoryImplementation;

public class AbstractFactorySweetCandyStore : AbstractFactoryCandyStore
{
    public override Candy GetCandy()
    {
        return new SweetCandy();
    }

    public override IWrapper GetWrapper()
    {
        return new PaperWrapper();
    }
}
