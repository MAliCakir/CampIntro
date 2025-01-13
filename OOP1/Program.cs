using OOP1;

class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product();
        product1.ProductId = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Masa";
        product1.UnitPrice = 500;
        product1.UnitsInStock = 3;

        Product product2 = new Product()
        {
            ProductId = 2,
            CategoryId=3,
            ProductName="Bilgisayar",
            UnitPrice=1250,
            UnitsInStock=15,
        };

        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
        Console.WriteLine(product1.ProductName);
    }
}