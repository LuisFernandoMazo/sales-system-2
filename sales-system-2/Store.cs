using System;
using System.Collections.Generic;
using System.Text;
using sales_system_2;

namespace sales_system_2
{
    class Store
    {
        Product[] pd = new Product[10];
        int pdCount = 0;

        Sale[] sale = new Sale[20];
        int slCount = 0;

        SalesMan[] salesMan = new SalesMan[20];
        int salesManCount = 0;
    
        public void AddProduct(Product NewProduct)
        {
            pd[pdCount] = NewProduct;
            pdCount++;
        }

        public void AddSale(Sale NewSale)
        {
            sale[slCount] = NewSale;
            slCount++;
        }

        public void AddSalesMan(SalesMan NewSalesMan)
        {
            salesMan[salesManCount] = NewSalesMan;
            salesManCount++;
        }

        public String NameSellerCheapest()
        {
            int count = 0;
            float PriceCheapest = 20000;
            String NameSalesMan = "";
            for (int i = 0; i < slCount; i++)
            {

                if (sale[i].Product.Price < PriceCheapest)
                {
                    PriceCheapest = sale[i].Product.Price;
                    NameSalesMan = sale[i].SalesMan.Name;
                }
            }
            return NameSalesMan;
        }

        public float PriceAverage()
        {
            int count = 0;
            float total = 0;
            float average = 0;
            for (int i = 0; i < pdCount; i++)
            {
                count++;
                total = total + pd[i].Price;
                average = total / count;

            }
            return average;
        }

        public int QuantitySoldProductsUnit()
        {
            int count = 0;
            String productName = "Keyboard";
            for (int i = 0; i < slCount; i++)
            {
                if (sale[i].Product.Name == productName)
                {
                    count++;
                }

            }
            return count;
        }
        public String MostExpensiveProduct()
        {
            int count = 0;
            float Price = 0;
            String NameProduct = "";
            for (int i = 0; i < pdCount; i++)
            {
                if (pd[i].Price > Price)
                {
                    Price = sale[i].Product.Price;
                    NameProduct = pd[i].Name;
                }
            }
            return NameProduct;
        }
    }

}
