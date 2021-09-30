using System;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes.Entities
{
    class Order
    {
        // ATRIBUTOS
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        // MÉTODOS
        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
