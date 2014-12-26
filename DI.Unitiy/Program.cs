using System;
using DI.Unitiy.Classes;
using DI.Unitiy.Interfaces;
using Microsoft.Practices.Unity;

namespace DI.Unitiy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register
            var container = new UnityContainer();
            container.RegisterType<IBillingProcessor, BillingProcessor>();
            container.RegisterType<ICustomer, Customer>();
            container.RegisterType<ILogger, Logger>();
            container.RegisterType<INotifier, Notifier>();

            Console.WriteLine("Unity DI Container Example");
            Console.WriteLine();

            var orderInfo = new OrderInfo
                {
                    CustomerName = "Rachid Lamtabbet",
                    CreditCard = "12457845125464721",
                    Price = 119.99,
                    Product = "Kindel WhitePaper 2",
                    Email = "Rlamtabbet@gmail.com"
                };

            Console.WriteLine("Production:");
            Console.WriteLine();

            // Resolve
            var commerce = container.Resolve<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.Read();
        }
    }
}
