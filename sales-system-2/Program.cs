using System;

namespace sales_system_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            SalesMan sm = new SalesMan();
            sm.Age = 20;
            sm.Name = "Luis";
            store.AddSalesMan(sm);

            SalesMan sm1 = new SalesMan();
            sm1.Age = 40;
            sm1.Name = "Manuela";
            store.AddSalesMan(sm1);

            SalesMan sm2 = new SalesMan();
            sm2.Age = 56;
            sm2.Name = "Edwar";
            store.AddSalesMan(sm2);

            SalesMan sm3 = new SalesMan();
            sm3.Age = 52;
            sm3.Name = "Maximo";
            store.AddSalesMan(sm3);

            // Products
            Product pd = new Product();
            pd.Name = "Headphones";
            pd.Price = 40000;
            store.AddProduct(pd);


            Product pd1 = new Product();
            pd1.Name = "Monitor LG";
            pd1.Price = 654152;
            store.AddProduct(pd1);

            Product pd2 = new Product();
            pd2.Name = "Mouse";
            pd2.Price = 20000;
            store.AddProduct(pd2);

            Product pd3 = new Product();
            pd3.Name = "Keyboard";
            pd3.Price = 100000;
            store.AddProduct(pd3);

            // sales
            Sale sl = new Sale();
            sl.Product = pd;
            sl.SalesMan = sm;
            sl.Comment = "Kotion Each G2000 Usb Microfono Ledl";
            store.AddSale(sl);

            Sale sl1 = new Sale();
            sl1.Product = pd1;
            sl1.SalesMan = sm1;
            sl1.Comment = "Led Ref: Ls24f350fh ";
            store.AddSale(sl1);

            Sale sl2 = new Sale();
            sl2.Product = pd2;
            sl2.SalesMan = sm2;
            sl2.Comment = "Mouse Ergonómico Microsoft Negro";
            store.AddSale(sl2);

            Sale sl3 = new Sale();
            sl3.Product = pd3;
            sl3.SalesMan = sm3;
            sl3.Comment = "Metallic Gamer Keyboard Wb-539 Backlit Mechanical";
            store.AddSale(sl3);


            String NameSalesMan = store.NameSellerCheapest();
            System.Console.WriteLine("Name of the seller who sold the cheapest product " + NameSalesMan);

            float PriceAverage = store.PriceAverage();
            System.Console.WriteLine("The products price average is: $" + PriceAverage);

            int ManyUnits = store.QuantitySoldProductsUnit();
            System.Console.WriteLine("The many unit of the product has been sold is: " + ManyUnits);

            String NameProduct = store.MostExpensiveProduct();
            System.Console.WriteLine("The most expensive product is: " + NameProduct);
        }
    }
}
