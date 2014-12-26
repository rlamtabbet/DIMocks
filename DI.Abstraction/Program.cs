using System;
using DI.Abstraction.Classes;

namespace DI.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderInfo = new OrderInfo
                {
                    CustomerName = "Rachid Lamtabbet",
                    CreditCard = "12457845125464721",
                    Price = 119.99,
                    Product = "Kindel WhitePaper 2"
                };

            Console.WriteLine("Production:");
            Console.WriteLine();

            var commerce = new Commerce(new BillingProcessor(), 
                                        new Customer(), 
                                        new Notifier(), 
                                        new Logger());

            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Test:");
            Console.WriteLine();

            var commerceTest = new Commerce(new TestBillingProcessor(),
                                            new TestCustomer(),
                                            new TestNotifier(),
                                            new TestLogger());

            commerceTest.ProcessOrder(orderInfo);

            Console.Read();
        }
    }
}
