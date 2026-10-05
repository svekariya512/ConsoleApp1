using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string name { get; set; }
        private int quantity;
        public double price { get; set; }
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }
        public double GetPrice()
        {
            return this.price;
        }


        public void Display()
        {
            Console.WriteLine("Product Name: " + name);
            Console.WriteLine("Product Quantity: " + quantity);
            Console.WriteLine("Product Price: " + price);
        }
    }
    

    class Class28
        {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.name = "Laptop";
            p1.SetQuantity(10);
            p1.price = 50000;
            p1.Display();

            Product p2 = new Product();
            p2.name = "Mobile";
            p2.SetQuantity(20);
            p2.price = 20000;
            p2.Display();

            Console.ReadLine();
        }
    }

   
}
