using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo_2.Entities
{
    abstract class TaxPayer // super classe abstrata
    {
        //atributos da super classe
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        //construtor da super classe
        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        //método abstrato da super classe
        public abstract double tax();

    }
}
