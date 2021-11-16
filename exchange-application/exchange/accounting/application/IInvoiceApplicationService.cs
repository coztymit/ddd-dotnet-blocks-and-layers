using System;
using exchange_application.exchange.accounting.application;

namespace exchange_application.exchange.accounting.application
{
    public interface IInvoiceApplicationService
    {
        public CreateStatus CreateInvoice(string number);
        public CreateStatus CreateInvoice();
        public CreateStatus CraeteCorrection(String number);

    }
}
