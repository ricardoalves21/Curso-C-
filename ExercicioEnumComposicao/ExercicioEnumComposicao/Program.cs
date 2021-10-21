using System;

namespace ExercicioEnumComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER CLIENT DATA:");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime moment = DateTime.Now;
            Console.WriteLine(moment.ToString("dd/MM/yyyy")); // para formatar exibição de data

            Client client = new Client(name, email, moment);

            Console.WriteLine();
            Console.WriteLine("Enter order data:");            
            Console.Write("Status: ");
            OrderStatus status = OrderStatus.Processing;
            Console.WriteLine(OrderStatus.Processing);
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= items; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Product myProduct = new Product(product, price);
                OrderItem orderItem = new OrderItem(quantity, price, myProduct);
            }

            

        }
    }
}
