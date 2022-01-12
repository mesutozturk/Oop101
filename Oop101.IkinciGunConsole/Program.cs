using System;
using Oop101.IkinciGun.Abstracts;
using Oop101.IkinciGun.Services;

namespace Oop101.IkinciGunConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            IPaymentService paymentService;


            //bin no sorgulanır. 

            int rnd = new Random().Next(0, 5);
            Console.WriteLine(rnd);
            decimal ucret = 1000;


            if (rnd == 0)
            {
                paymentService = new BonusPaymentService();
            }
            else if (rnd == 1)
            {
                paymentService = new FinansPaymentService();
            }
            else if (rnd == 2)
            {
                paymentService = new MaximumPaymentService();
            }
            else if (rnd == 3)
            {
                paymentService = new AmexPaymentService();
            }
            else
            {
                paymentService = new BonusPaymentService();
            }

            paymentService.MakePayment(ucret, 2, "Kamil");

        }
    }
}
