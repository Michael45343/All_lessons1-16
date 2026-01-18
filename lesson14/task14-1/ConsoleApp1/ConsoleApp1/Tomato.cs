public class Tomato : Product
{
    public override string Name => "Tomato";

    public Tomato(double price) : base(price) { }

    public override void PrintInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price}");
    }
}
