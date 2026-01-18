public class Carrot : Product
{
    public override string Name => "Carrot";

    public Carrot(double price) : base(price) { }

    public override void PrintInfo()
    {
        Console.WriteLine($"Product: {Name}, Price: {Price}");
    }
}
