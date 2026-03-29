using G_NET_18_ADV02.Class;

namespace G_NET_18_ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            List<Product> products = new List<Product>()
            {
                new Product(1 , "labtop" , "Elctronics" , 20000 , 10),
                new Product(2 , "Phone" , "Elctronics" , 7000 , 5),
                new Product(3 , "T-shirt" , "Clothing" , 500 , 15),
                new Product(4 , "Jeans" , "Clothing" , 900 , 100),
                new Product(5 , "Chocolate" , "Food" , 30 , 10),
                new Product(6 , "novel" , "Books" , 200 , 11),
                new Product(7 , "Jacket" , "Clothing" , 650, 104),
            };

            //List<Product> res = SearchProducts(products, p => p.Category == "Elctronics"); 
            #endregion


            #region Task02
            //PrintReport(products , p => Console.WriteLine($"{p.Name} - ${p.Price}"));
            //Console.WriteLine();
            //PrintReport(products, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));
            #endregion

        }

        static List<Product> SearchProducts(List<Product> products , Func<Product, bool> ProductExists)
        {
            List<Product> res = [];

            foreach (var item in products)
            {
                if (ProductExists(item))
                {
                    res.Add(item);
                }
            }

            return res;
        }


        static void PrintReport(List<Product> products , Action<Product> PrintProduct)
        {
            foreach (var item in products)
            {
                PrintProduct(item);
            }
        }


    }
}
