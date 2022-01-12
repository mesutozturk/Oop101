namespace Oop101.IkinciGun.Abstracts
{
    public interface IPaymentService
    {
        bool MakePayment(decimal amount, int installment, string customer);
    }
}