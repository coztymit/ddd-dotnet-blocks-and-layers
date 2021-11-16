using System;
namespace exchange_domain.exchange.accounting.domain
{
    public class InvoiceService
    {
        public InvoiceService()
        {
            
        }

        public Payment CreatePayment(Invoice invoice, PaymentPolicy policy)
        {
            return new Payment();
        }
    }
}
