using ExercicioHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listCommon = new List<Product>();
            List<ImportedProduct> listImported = new List<ImportedProduct>();
            List<UsedProduct> listUsed = new List<UsedProduct>();

            Console.Write("Enter the number os products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++ )
            {
                Console.WriteLine($"Product #{i} data:"); // usando interpolação
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                
                if (type.Equals('i')) // comparando a variável do tipo 'char'
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    listImported.Add(new ImportedProduct(name, price, customsFee));
                } 
                else if (type.Equals('u'))
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    listUsed.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    listCommon.Add(new Product(name, price));
                }                
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            Console.WriteLine();

            foreach (Product p in listCommon)
            {
                Console.WriteLine(p);
            }
            foreach (ImportedProduct i in listImported)
            {
                Console.WriteLine(i);
            }
            foreach (UsedProduct u in listUsed)
            {
                Console.WriteLine(u);
            }
        }
    }
}
