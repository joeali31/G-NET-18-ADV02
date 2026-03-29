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


            #region Task03
            //List<Product> res = FilterProducts(products, p => p.Stock < 20);
            //Console.WriteLine("--- Low-Stock Alert ---");
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"[LOW STOCK] {item.Name}: only {item.Stock} left!");
            //}
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


        static List<Product> FilterProducts(List<Product> products , Predicate<Product> matchCondition)
        {
            List<Product> res = [];

            foreach (var item in products)
            {
                if (matchCondition(item))
                {
                    res.Add(item);
                }
            }

            return res;
        }

    }
}
