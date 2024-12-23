namespace FactoryMethod;

public class Program
{
    public static void Main()
    {
        var candyStore = new SimpleCandyStore();
        candyStore.SellCandy("Sour_Candy");
        candyStore.SellCandy("Sweet_Candy");
    }
}
