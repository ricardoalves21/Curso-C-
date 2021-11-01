using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo.Entities
{
    class Product
    {
        // atributos
        public string Name { get; set; }
        public double Price { get; set; }

        // construtor
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public Product()
        {
        }

        // métodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + " $ " + Price);
            return sb.ToString();
        }
    }
}
