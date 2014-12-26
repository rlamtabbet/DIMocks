using DI.Coupled.Classes;

namespace DI.Coupled
{
    public class Commerce
    {
        private readonly BillingProcessor _billingProcessor;
        private readonly Customer _customer;
        private readonly Notifier _notifier;
        private readonly Logger _logger;

        public Commerce(BillingProcessor billingProcessor,
                        Customer customer, Notifier notifier, Logger logger)
        {
            _billingProcessor = billingProcessor;
            _customer = customer;
            _notifier = notifier;
            _logger = logger;
        }

        public void ProcessOrder(OrderInfo orderInfo)
        {
            _billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCard, orderInfo.Price);
            _logger.Log("Billing Processed");
            _customer.UpdateCustomerOrder(orderInfo.CustomerName, orderInfo.Product);
            _logger.Log("Customer updated");
            _notifier.SendReceipt(orderInfo);
            _logger.Log("Receipt sent");
        }
    }
}
