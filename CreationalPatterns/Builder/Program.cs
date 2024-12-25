namespace Builder;

public class Program
{
    public static void Main()
    {
        var builder = new URLBuilder.Builder();
        builder.Protocol("htttps://").DomainName("www.Slayer.com").Port(":2801/");
        var urlBuilder = builder.Build();

        Console.WriteLine(urlBuilder.protocol + urlBuilder.domainName + urlBuilder.port);
    }
}