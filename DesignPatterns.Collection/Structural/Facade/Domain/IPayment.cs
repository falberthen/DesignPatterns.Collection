namespace DesignPatterns.Structural.Facade.Domain
{
    public interface IPayment
    {
        string DoPayment(Order order, Payment payment);
    }
}