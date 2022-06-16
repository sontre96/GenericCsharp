using System;
using System.Collections;


namespace Generic1
{
    class Product
    {
        public string name { get; set; }
        double cost { get; set; }
        int onhand { get; set; }
        public Product(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }

        public override string ToString()
        {
            return String.Format("{0, -10}Cost: {1, 6:C} On hand: {2}", name, cost, onhand);
        }
    }

    class Program
    {
        public static void Main()
        {
            List<Product> inv = new List<Product>();

            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 8));

            Console.WriteLine("Product list:");
            foreach (Product i in inv)
            {
                Console.WriteLine(" " + i);
            }
        }
    }
}
