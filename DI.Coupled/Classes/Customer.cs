using System;

namespace DI.Coupled.Classes
{
    public class Customer
    {
        public void UpdateCustomerOrder(string customer, string product)
        {
            // update customer record with purchase
            Console.WriteLine("Customer record for '{0}' updated", customer);
        }
    }
}