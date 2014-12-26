using System;
using DI.Ninject.Classes;
using DI.Ninject.Interfaces;
using Ninject;

namespace DI.Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register
            var container = new StandardKernel();
            container.Bind<IBillingProcessor>().To<BillingProcessor>();
            container.Bind<ICustomer>().To<Customer>();
            container.Bind<ILogger>().To<Logger>();
            container.Bind<INotifier>().To<Notifier>();

            Console.WriteLine("Ninject DI Container Example");
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
            var commerce = container.Get<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.Read();
        }
    }
}
