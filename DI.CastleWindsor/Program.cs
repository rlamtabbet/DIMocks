using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DI.CastleWindsor.Classes;
using DI.CastleWindsor.Interfaces;

namespace DI.CastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            // Register: First class needs to be registred as well
            container.Register(Component.For<Commerce>());
            container.Register(Component.For<IBillingProcessor>().ImplementedBy<BillingProcessor>());
            container.Register(Component.For<ICustomer>().ImplementedBy<Customer>());
            container.Register(Component.For<ILogger>().ImplementedBy<Logger>());
            container.Register(Component.For<INotifier>().ImplementedBy<Notifier>());

            Console.WriteLine("Castle Windsor DI Container Example");
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
