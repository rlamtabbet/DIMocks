using System;
using DI.StructureMap.Classes;
using DI.StructureMap.Interfaces;
using StructureMap;

namespace DI.StructureMap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register
            var container = new Container();
            container.Configure(reg => reg.For<IBillingProcessor>().Use<BillingProcessor>());
            container.Configure(reg => reg.For<ICustomer>().Use<Customer>());
            container.Configure(reg => reg.For<INotifier>().Use<Notifier>());
            container.Configure(reg => reg.For<ILogger>().Use<Logger>());

            Console.WriteLine("StructureMap DI Container Example");
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
            var commerce = container.GetInstance<Commerce>();
            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.Read();
        }
    }
}
