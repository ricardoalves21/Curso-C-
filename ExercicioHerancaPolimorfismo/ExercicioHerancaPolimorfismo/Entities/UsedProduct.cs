using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        

        //atributos
        public DateTime ManufacturedDate { get; set; }

        //construtor
        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }
        public UsedProduct()
        {
        }

        //métodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name + " (used) $ " + Price + " (Manufacture date: " + ManufacturedDate);

            return sb.ToString();
        }

    }
}
