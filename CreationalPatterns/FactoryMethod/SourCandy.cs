namespace FactoryMethod;

public class SourCandy : Candy
{
    public string Name()
    {
        return "Sour Candy";
    }

    public int Sweetness()
    {
        return 2;
    }
}