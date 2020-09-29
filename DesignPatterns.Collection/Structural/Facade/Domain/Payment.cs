namespace DesignPatterns.Structural.Facade.Domain
{
    public class Payment
    {
        public string CardNumber { get; set; }
        public decimal Value { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
    }
}