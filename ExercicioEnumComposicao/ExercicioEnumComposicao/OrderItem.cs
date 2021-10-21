
namespace ExercicioEnumComposicao
{
    class OrderItem
    {
        // atributos
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } // composição simples

        // construtores
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public OrderItem()
        {
        }

        // métodos
        public double subTotal()
        {
            return Quantity * Price;
        }

    }
}
