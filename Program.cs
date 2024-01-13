

using System.Globalization;
using exercicios_6.Entities;

List <Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for(int count = 1; count <= n; count++)
{
    Console.WriteLine($"Product #{count} data: ");
    Console.Write($"Common, used or imported (c/u/i)? ");
    char status = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(status == 'i')
    {
        Console.Write("Customs fee: ");
        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customFee));
    }
    else if(status == 'u')
    {
        DateTime date = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, date));
    }
    else
    {
        products.Add(new Product(name, price));
    }
}


Console.WriteLine("\nPRICE TAGS:");
foreach(Product product in products)
{
    Console.WriteLine(product.PriceTag());
}