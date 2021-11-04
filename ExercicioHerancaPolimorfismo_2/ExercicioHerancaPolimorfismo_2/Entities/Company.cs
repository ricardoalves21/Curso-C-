using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo_2.Entities
{
    class Company : TaxPayer // subclasse herdada
    {
        //atributos da subclasse
        public int NumberOfEmployees { get; set; }

        //construtor da subclasse
        public Company(string name, double anualIncome, int numberOfEmployees) : base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        //método sobrescrito da subclasse
        public override double tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
