using System;
using exchange_application.exchange.accounting.application;

namespace exchange_application.exchange.accounting.application
{
    public interface IInvoiceApplicationService
    {
        public CreateStatus createInvoice(string number);
        public CreateStatus createInvoice();
        public CreateStatus craeteCorrection(String number);

    }
}
