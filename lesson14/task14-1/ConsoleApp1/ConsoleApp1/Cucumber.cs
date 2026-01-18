public class Cucumber : Product
{
    public int Count { get; }

    public override string Name => "Cucumber";

    public override double Price => BasePrice * Count;

    public Cucumber(double pricePerKg, int count) : base(pricePerKg)
    {
        Count = count;
    }

    public override void PrintInfo()
    {
        Console.WriteLine(
            $"Product: {Name}, Price: {BasePrice}, Count: {Count}, Total price: {Price}"
        );
    }
}
