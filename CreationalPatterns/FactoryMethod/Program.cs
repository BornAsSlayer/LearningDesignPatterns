namespace FactoryMethod;

public class Program
{
    public static void Main()
    {
        //simple factory Implementatiom
        Console.WriteLine("simple factory Implementation");

        var candyStore = new SimpleCandyStore();
        candyStore.SellCandy("Sour_Candy");
        candyStore.SellCandy("Sweet_Candy");

        //full factory Implementation
        Console.WriteLine("full factory Implementation");

        var fullFactorySourCandy = new FullFactorySourCandy();
        var fullFactorySweetCandy = new FullFactorySweetCandy();
        fullFactorySourCandy.SellCandy();
        fullFactorySweetCandy.SellCandy();

    }
}
