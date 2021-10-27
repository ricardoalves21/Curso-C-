using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        //atributos
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }
        public UsedProduct()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
