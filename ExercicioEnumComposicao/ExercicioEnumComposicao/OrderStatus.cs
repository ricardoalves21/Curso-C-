
namespace ExercicioEnumComposicao
{
    enum OrderStatus : int // classe do tipo ENUM que está herdando atributos e métodos da classe INT
    {
        PendingPayment = 0,
        Processing = 1,
        Shipper = 2,
        Delivered = 3
    }
}
