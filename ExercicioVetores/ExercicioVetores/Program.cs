using System;


namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("De quantos quartos precisará? ");
            int n = int.Parse(Console.ReadLine());

            Hospedagem[] hosp = new Hospedagem[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hospedagem #"+(i+1)+":");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                hosp[i] = new Hospedagem { Nome = nome, Email = email, Quarto = quarto };
            }

            Array.Sort(hosp, );
            Console.WriteLine();
            Console.WriteLine("HOSPEDAGENS:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(hosp[i]);
            }
        }
    }
}
