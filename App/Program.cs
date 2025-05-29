namespace App;
public class Greeter
{
    public static string SayHello(string name) => $"Hello, {name}!";
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Greeter.SayHello("World"));
    }
}
