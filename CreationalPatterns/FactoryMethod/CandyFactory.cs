namespace FactoryMethod;

public class SimpleCandyFactory
{
    public static Candy GetCandy(string candyType)
    {
        return candyType switch 
        {
            "Sweet_Candy" => new SweetCandy(),
            "Sour_Candy" => new SourCandy(),
            _ => throw new ArgumentException("Invalid Argument")
        };
    }
}
