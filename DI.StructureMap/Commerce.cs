using DI.StructureMap.Interfaces;

namespace DI.StructureMap
{
    public class Commerce
    {
        private readonly IBillingProcessor _billingProcessor;
        private readonly ICustomer _customer;
        private readonly INotifier _notifier;
        private readonly ILogger _logger;

        public Commerce(IBillingProcessor billingProcessor,
                        ICustomer customer, INotifier notifier, ILogger logger)
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
