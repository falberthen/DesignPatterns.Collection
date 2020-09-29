using System;
using System.Linq;

namespace DesignPatterns.Structural.Facade.Domain
{
    /// <summary>
    /// Domain Service using the OnlinePaymentServiceFacade
    /// </summary>
    public class OnlinePaymentService : IPayment
    {
        private readonly IOnlinePaymentServiceFacade _onlinePaymentFacade;

        public OnlinePaymentService(IOnlinePaymentServiceFacade onlinePaymentServiceFacade)
        {
            _onlinePaymentFacade = onlinePaymentServiceFacade;
        }

        public string DoPayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Price);
            Console.WriteLine($"Starting payment - Total ${payment.Value}");
            string transactionResult = string.Empty;

            if (_onlinePaymentFacade.DoPayment(order, payment))
            {
                switch (payment.PaymentMethod)
                {
                    case PaymentMethods.CreditCard:
                        transactionResult = "Successfully paid via Credit Card";
                        break;
                    case PaymentMethods.DebitCard:
                        transactionResult = "Successfully paid via Debit Card";
                        break;
                    default:
                        break;                    
                }

                return transactionResult;
            }

            return "Sorry. Your card was declined!";            
        }
    }
}