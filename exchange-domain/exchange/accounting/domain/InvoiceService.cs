using System;
namespace itmdevlabs_currency_exchange.exchange.accounting.domain
{
    public class InvoiceService
    {
        public InvoiceService()
        {
            
        }

        public Payment createPayment(Invoice invoice, PaymentPolicy policy)
        {
            return new Payment();
        }
    }
}
