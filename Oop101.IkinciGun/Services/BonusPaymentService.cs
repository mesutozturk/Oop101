using System;
using Oop101.IkinciGun.Abstracts;

namespace Oop101.IkinciGun.Services
{
    public class BonusPaymentService : BasePaymentService, IPaymentService
    {
        public BonusPaymentService()
        {
            CommissionRate = 1.12m;
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
