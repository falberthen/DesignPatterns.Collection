namespace DesignPatterns.Structural.Facade.Domain
{
    public interface IOnlinePaymentServiceFacade
    {
        bool DoPayment(Order order, Payment payment);
    }
}