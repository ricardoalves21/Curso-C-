using System;

namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
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
                } 
                else if (type.Equals('u'))
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                }
            }
        }
    }
}
