namespace FactoryMethod;

public class SweetCandy : Candy
{
    public override string Name()
    {
        return "Sweet Candy";
    }

    public override int Sweetness()
    {
        return 10;
    }
}