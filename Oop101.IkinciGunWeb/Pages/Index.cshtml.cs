using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oop101.IkinciGun.Abstracts;
using Oop101.IkinciGun.Services;

namespace Oop101.IkinciGunWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private IPaymentService _payment;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            int rnd = new Random().Next(0, 5);
            Console.WriteLine(rnd);
            decimal ucret = 1000;


            if (rnd == 0)
            {
                _payment = new BonusPaymentService();
            }
            else if (rnd == 1)
            {
                _payment = new FinansPaymentService();
            }
            else if (rnd == 2)
            {
                _payment = new MaximumPaymentService();
            }
            else if (rnd == 3)
            {
                _payment = new AmexPaymentService();
            }
            else
            {
                _payment = new BonusPaymentService();
            }

            _logger.LogInformation("Deneme");

            _payment.MakePayment(ucret, 2, "Kamil");
        }
    }
}
