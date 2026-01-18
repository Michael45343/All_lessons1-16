using System.Collections.Generic;

public class VegetableShop
{
    private List<Product> products = new List<Product>();

    public void AddProducts(List<Product> newProducts)
    {
        products.AddRange(newProducts);
    }

    public void PrintProductsInfo()
    {
        double totalPrice = 0;

        foreach (var product in products)
        {
            product.PrintInfo();
            totalPrice += product.Price;
        }

        Console.WriteLine($"Total products price: {totalPrice}");
    }
}
