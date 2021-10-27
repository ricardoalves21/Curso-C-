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
        public virtual string priceTag()
        {
            return Price.ToString();
        }




    }
}
