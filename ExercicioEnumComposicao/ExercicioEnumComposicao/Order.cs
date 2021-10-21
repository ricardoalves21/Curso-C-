using System;
using System.Collections.Generic;

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
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
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
            foreach(OrderItem items in Items)
            {
                sum += items.subTotal();
            }
            return sum;
        }

    }
}
