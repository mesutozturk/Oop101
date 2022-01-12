using Oop101.IkinciGun.Abstracts;
using System;

namespace Oop101.IkinciGun.Services
{
    public class AmexPaymentService : BasePaymentService, IPaymentService
    {
        public AmexPaymentService()
        {
            CommissionRate = 1.9m;
        }
        public bool MakePayment(decimal amount, int installment, string customer)
        {
            if (amount <= 0) return false;

            var paid = amount * CommissionRate;
            var perInstallment = paid / installment;

            Console.WriteLine($"{customer}: {installment} x {perInstallment:n2} Total: {paid:n2}");
            return true;
        }
    }
}
