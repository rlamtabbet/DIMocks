using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Coupled.Classes;

namespace DI.Coupled
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

            var commerce = new Commerce(new BillingProcessor(),
                                        new Customer(),
                                        new Notifier(),
                                        new Logger());

            commerce.ProcessOrder(orderInfo);

            Console.Read();
        }
    }
}
