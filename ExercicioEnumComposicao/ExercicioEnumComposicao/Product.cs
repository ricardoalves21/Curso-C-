
namespace ExercicioEnumComposicao
{
    class Product
    {
        // atributos
        public string Name { get; set; }
        public double Price { get; set; }

        // construtores
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
        }
    }
}
