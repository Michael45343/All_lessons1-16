public abstract class Product
{
    protected double BasePrice;

    public abstract string Name { get; }

    // Цена продукта (по умолчанию = BasePrice)
    public virtual double Price => BasePrice;

    protected Product(double basePrice)
    {
        BasePrice = basePrice;
    }

    public abstract void PrintInfo();
}
