using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumComposicao
{
    class Order
    {
        // atributos
        public  DateTime Moment{ get; set; }
        public OrderStatus Status { get; set; } // composição simples (relação tem um)
        public Client Client { get; set; } // composição simples (relação tem um)
        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); // composição lista (relação tem muitos)

        // construtores
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public Order()
        {
        }

        // método adiciona item
        public void AddItem (OrderItem item)
        {
            Items.Add(item);
        }

        // método remove item
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        // método totaliza pedido
        public double totalPedido()
        {
            double sum = 0;
            foreach(OrderItem sumItems in Items)
            {
                sum += sumItems.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order items:");

            foreach (OrderItem c in Items)
            {
                sb.AppendLine(c.Product.Name.ToString() + ", $" + c.Price.ToString() + ", Quantity: " + c.Quantity.ToString() + ", Subtotal: " + c.subTotal());
            }
            
            return sb.ToString();
        }

    }
}
