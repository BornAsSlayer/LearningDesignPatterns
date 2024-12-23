namespace FactoryMethod;

public class SweetCandy : Candy
{
    public string Name()
    {
        return "Sweet Candy";
    }

    public int Sweetness()
    {
        return 10;
    }
}