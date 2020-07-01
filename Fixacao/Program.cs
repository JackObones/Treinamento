using System;
using Fixacao.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char x = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (x == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (x == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else 
                {
                    Console.Write("Custom fee:");
                    double customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                
                
                Console.WriteLine();
                Console.WriteLine("Price Tags:");
                foreach(Product pro in list)
                {
                    Console.WriteLine(pro.PriceTag());
                }
               
            }
        }
    }
}
