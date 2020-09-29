using DesignPatterns.Structural.Facade.Domain;
using DesignPatterns.Structural.Facade.Subsystem;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class FacadeTest
    {
        public static void Execute()
        {
            ServiceProvider serviceProvider = BuildServiceProvider();
            var _onlinePaymentService = serviceProvider.GetService<IPayment>();

            var order = new Order() { Products = new List<Product>() };

            for (int i = 1; i <= 5; i++)
            { 
                order.Id = Guid.NewGuid();
                order.Products.Add(new Product { Name = $"Product {i}", Price = new Random().Next(500) });
            }

            var payment = new Payment() {
                CardNumber = "3333 2222 5555 9999",
                PaymentMethod = RandomPaymentMethod()
            };            

            var result = _onlinePaymentService.DoPayment(order, payment);
            Console.WriteLine(result);
        }

        private static PaymentMethods RandomPaymentMethod()
        {
            var rnd = new Random();
            return (PaymentMethods)rnd.Next(Enum.GetNames(typeof(PaymentMethods)).Length);
        }

        private static ServiceProvider BuildServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddScoped<IPayment, OnlinePaymentService>();
            services.AddScoped<IOnlinePaymentServiceFacade, OnlinePaymentServiceFacade>();
            services.AddScoped<IPayPalGateway, PayPalGateway>();
            services.AddScoped<IConfigurationManager, ConfigurationManager>();
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
