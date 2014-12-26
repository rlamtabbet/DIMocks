using System;
using System.ComponentModel.Composition;
using DI.MEF.Interfaces;

namespace DI.MEF.Classes
{
    [Export(typeof(ICustomer))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Customer : ICustomer
    {
        public void UpdateCustomerOrder(string customer, string product)
        {
            // update customer record with purchase
            Console.WriteLine("Customer record for '{0}' updated", customer);
        }
    }
}