using FactoryMethod.AbstractFactoryImplementation;

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

        var fullFactorySourCandyStore = new FullFactorySourCandyStore();
        var fullFactorySweetCandyStore = new FullFactorySweetCandyStore();
        fullFactorySourCandyStore.SellCandy();
        fullFactorySweetCandyStore.SellCandy();

        //abstract factory Implementation
        Console.WriteLine("full factory Implementation");

        var abstractFactorySourCandyStore = new AbstractFactorySourCandyStore();
        var abstractFactorySweetCandyStore = new AbstractFactorySweetCandyStore();
        abstractFactorySourCandyStore.SellCandy();
        abstractFactorySweetCandyStore.SellCandy();

    }
}
