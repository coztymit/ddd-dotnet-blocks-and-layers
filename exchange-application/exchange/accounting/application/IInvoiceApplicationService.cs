using System;
using itmdevlabs_currency_exchange.exchange.accounting.application;

namespace currency_exchange.exchange.accounting.application
{
    public interface IInvoiceApplicationService
    {
        public CreateStatus createInvoice(string number);
        public CreateStatus createInvoice();
        public CreateStatus craeteCorrection(String number);

    }
}
