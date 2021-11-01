using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        // atributos
        public double CustomFee { get; set; }

        // construtor
        public ImportedProduct(string name, double price, double customFee) : base (name, price)
        {
            CustomFee = customFee;
        }
        public ImportedProduct()
        {
        }

        //métodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $ " + Price + " (Customs fee: $ " + CustomFee + ")");

            return sb.ToString();
        }
    }
}
