namespace Oop101.IkinciGun.Abstracts
{
    public abstract class BasePaymentService
    {
        public decimal CommissionRate { get; set; } = 1;
        public string ServiceKey { get; set; }
        public string SecretKey { get; set; }
        public string ApiUrl { get; set; }
    }
}