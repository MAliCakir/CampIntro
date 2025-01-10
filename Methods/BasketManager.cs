using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BasketManager
    {
        public void AddBasket(Product product)
        {
            Console.WriteLine(product.ProductName + " Sepete eklendi. Kalan stok "+product.StockQuantity);
        }

        public void AddBasket2(string name,string description,double price, int stock )
        {
            Console.WriteLine(name + " "+description+" "+price + " "+stock);
        }
    }
}
