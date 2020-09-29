using DesignPatterns.Structural.Facade.Subsystem;

namespace DesignPatterns.Structural.Facade.Domain
{
    /// <summary>
    /// Service Facade
    /// </summary>
    public class OnlinePaymentServiceFacade : IOnlinePaymentServiceFacade
    {
        private readonly IPayPalGateway _payPalGateway;
        private readonly IConfigurationManager _configManager;

        public OnlinePaymentServiceFacade(IPayPalGateway payPalGateway, IConfigurationManager configManager)
        {
            _payPalGateway = payPalGateway;
            _configManager = configManager;
        }

        public bool DoPayment(Order pedido, Payment pagamento)
        {
            var apiKey = _configManager.GetValue("apiKey");
            var encriptionKey = _configManager.GetValue("encriptionKey");

            var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, pagamento.CardNumber);

            var pagamentoResult = _payPalGateway.CommitTransaction(cardHashKey, pedido.Id.ToString(), pagamento.Value);

            return pagamentoResult;
        }
    }
}