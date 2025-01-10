using Methods;

class Program
{
    private static void Main(string[] args)
    {
        // Dont Repeat Yourself - DRY
        // Methods ensure repeated usability - metotlar tekrar tekrar kullanımı sağlar
        // Best practice - Clean code

        Product product = new Product()
        {
            ProductName = "Elma",
            Id = 1,
            Price = 25,
            Description = "Amasya Elması",
            StockQuantity=30

        };

        Product product1 = new Product()
        {
            ProductName = "Armut",
            Id = 2,
            Price = 20,
            Description = "Deveci Armutu",
            StockQuantity=50
        };

        Product[] Fruits = new Product[] { product,product1 };

        foreach (Product item in Fruits)
        {
            Console.Write("Ürün Adı : "+item.ProductName+"\n"+
                "Ürün Fiyatı : "+item.Price+
                "\nÜrün Açıklaması : " + item.Description+
                "\n -----------------------\n");
        }

        Console.WriteLine("---------------METHODS------------------\n");
        /*If we needed to make changes or add features about the product in our warehouse,
         our method numbered Add to cart 2 below would explode, 
         but in this method we only need to go to the class and add the
         necessary feature. We call it encapsulation*/
        BasketManager basketManager = new BasketManager();
        Console.WriteLine("Encapsulation example");
        basketManager.AddBasket(product);
        basketManager.AddBasket(product1);

        Console.WriteLine("non Encapsulation");
        // we should fix all AddBasket2 methots for not explode our programme
        basketManager.AddBasket2("elma", "yesil elma", 25, 30);
        basketManager.AddBasket2("armut", "deveci armut", 25, 50);
    }
}