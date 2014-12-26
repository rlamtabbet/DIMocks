using System;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace DI.MEF
{
    class Program
    {
        public static CompositionContainer Container;
        static void Main(string[] args)
        {
            // Register (using attributes in the class themselves)
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            Container = new CompositionContainer(catalog);

            Console.WriteLine("MEF DI Container Example");
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
            var commerce = Container.GetExportedValue<Commerce>();

            // Post Resolve
            //var commerce = new Commerce(); // require that Commerce satisfies its own imports
            //Container.SatisfyImportsOnce(commerce);

            commerce.ProcessOrder(orderInfo);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.Read();
        }
    }
}
