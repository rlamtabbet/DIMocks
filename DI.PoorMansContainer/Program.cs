using System;
using DI.PoorMansContainer.Classes;
using DI.PoorMansContainer.DIContainer;
using DI.PoorMansContainer.Interfaces;

namespace DI.PoorMansContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.Register<IBillingProcessor, BillingProcessor>();
            container.Register<ICustomer, Customer>();
            container.Register<ILogger, Logger>();
            container.Register<INotifier, Notifier>();

            Console.WriteLine("Poor Man's DI Container Example");
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

            var commerce = container.Resolve<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.Read();
        }
    }
}
