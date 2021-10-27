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

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
