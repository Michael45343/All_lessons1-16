public class Potato : Product
{
    public int Count { get; }

    public override string Name => "Potato";

    public override double Price => BasePrice * Count;

    public Potato(double pricePerKg, int count) : base(pricePerKg)
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
