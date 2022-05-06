// var products = ProductManager.GetProducts();

// Console.WriteLine($"| ProductId | Name | Price | isApproove");
// foreach (var p in products)
// {
//     Console.WriteLine($"| {p.ProductId}         | {p.Name} | {p.Price} | {p.isApproove} |");
// }

// Product product = ProductManager.GetProductById(4);
// Console.WriteLine($"| {product.ProductId} | {product.Name} | {product.Price} | {product.isApproove} |");

Product product = ProductManager.GetProductByName("8");
Console.WriteLine($"| {product.ProductId} | {product.Name} | {product.Price} | {product.isApproove} |");

class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public bool isApproove { get; set; }
}

static class ProductManager
{
    static Product[] Products;
    static ProductManager()
    {
        Products = new Product[5];
        Products[0]= new Product{ProductId=1,Name="Iphone 5",Price=2000,isApproove=false};
        Products[1]= new Product{ProductId=2,Name="Iphone 6",Price=3000,isApproove=false};
        Products[2]= new Product{ProductId=3,Name="Iphone 7",Price=4000,isApproove=true};
        Products[3]= new Product{ProductId=4,Name="Iphone 8",Price=5000,isApproove=true};
        Products[4]= new Product{ProductId=5,Name="Iphone X",Price=6000,isApproove=true};
    }

    public static Product[] GetProducts()
    {
        return Products;
    }
    public static Product GetProductById(int id)
    {
        Product product = null;
        foreach (var p in Products)
        {
            if (p.ProductId == id)
                product = p;
                break;
        }

        return product;
    }
    public static Product GetProductByName(string name)
    {
        Product product = null;
        foreach (var p in Products)
        {
            if (p.Name.Contains(name.ToLower()))
            {
                product = p;
                break;
            }
        }
        return product;
    }
}