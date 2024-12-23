namespace FactoryMethod;

public class SourCandy : Candy
{
    public override string Name()
    {
        return "Sour Candy";
    }

    public override int Sweetness()
    {
        return 2;
    }
}