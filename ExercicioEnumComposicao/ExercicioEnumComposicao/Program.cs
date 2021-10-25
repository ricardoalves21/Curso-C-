using System;
using System.Collections.Generic;

namespace ExercicioEnumComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem orderItem = new OrderItem();

            Console.WriteLine("ENTER CLIENT DATA:");
            
        // nome do cliente
            Console.Write("Name: ");
            string name = Console.ReadLine();

        // email do cliente
            Console.Write("Email: ");
            string email = Console.ReadLine();

        // data de cadastro do cliente
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dateClient = DateTime.Parse(Console.ReadLine());

        // adiciona o cliente na classe Client
            Client client = new Client(name, email, dateClient);
            Console.WriteLine(); // pular linha

            Console.WriteLine("Enter order data:");      
            
        // pega o status do pedido na classe OrderStatus
            Console.Write("Status: ");
            OrderStatus status = OrderStatus.Processing;
            Console.WriteLine(OrderStatus.Processing);

        // quantidade de itens que serão lançadas no pedido
            Console.Write("How many items to this order? ");
            int qtdItems = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // adiciona o item na classe Order
            DateTime dateOrder = DateTime.Now;
            Order order = new Order(dateOrder, status, client);

            for (int i = 1; i <= qtdItems; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");

        // COMPONDO A CLASSE OrderItem.cs ////////// início ///////////
            // produto
                Console.Write("Product name: ");
                string product = Console.ReadLine();

            // preço
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

            // quantidade
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine();
        // COMPONDO A CLASSE OrderItem.cs ////////// término ///////////


            // adiciona o produto na classe Product
                Product myProduct = new Product(product, price);

            // adiciona o item na classe OrderItem
                orderItem = new OrderItem(quantity, price, myProduct);                
                orderItem.subTotal();
                order.AddItem(orderItem);
                order.totalPedido();
            }   

        // APRESENTAR CLIENTE E PEDIDO NA TELA /////////////////////////

            Console.WriteLine("ORDER SUMMARY --------------------------------");
            Console.Write("Order moment: ");
            Console.WriteLine(dateOrder.ToString("dd/MM/yyyy HH:mm:ss"));
            Console.WriteLine("Client: " + name + " (" + dateClient.ToString("dd/MM/yyyy") + ") - " + email);
            Console.WriteLine();
            Console.WriteLine(order.ToString());
            Console.WriteLine("Total price: $" + order.totalPedido());         
        }
    }
}
