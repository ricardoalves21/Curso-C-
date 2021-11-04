using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo_2.Entities
{
    class Individual : TaxPayer //subclasse herdada
    {
        //atributos da subclasse
        public double HealthExpenditures { get; set; }

        //construtor da subclasse
        public Individual(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        //método sobrescrito da subclasse
        public override double tax()
        {
            if (AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
