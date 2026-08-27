namespace Assignment_11_Advanced_2;

internal class Program
{
    static void Main(string[] args)
    {
        List<Product> catalog = new List<Product>()
            {
                new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
                new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
                new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
                new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
                new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
                new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
                new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
            };


        #region Task1_Smart Product Search
        //Console.WriteLine("--- Electronics ---");
        //var electronics = SearchProducts(catalog, p => p.Category == "Electronics");
        //PrintProducts(electronics);

        //Console.WriteLine("--- Under $50 ---");
        //var under50 = SearchProducts(catalog, p => p.Price < 50);
        //PrintProducts(under50);

        //Console.WriteLine("--- In Stock ---");
        //var inStock = SearchProducts(catalog, p => p.Stock > 0);
        //PrintProducts(inStock);

        //Console.WriteLine("--- Clothing Under $100 ---");
        //var clothingUnder100 = SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
        //PrintProducts(clothingUnder100);
        #endregion

    }

    static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
    {
        List<Product> filteredList = new List<Product>();

        foreach (var product in products)
        {
            if (filter(product)) 
            {
                filteredList.Add(product);
            }
        }
        return filteredList;
    }

    static void PrintProducts(List<Product> products)
    {
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
        }
        Console.WriteLine();
    }

}