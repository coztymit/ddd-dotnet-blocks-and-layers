namespace itmdevlabs_currency_exchange.exchange.accounting.domain
{
    public class InvoiceCreateStatus
    {

        public static InvoiceCreateStatus CORRECT = new InvoiceCreateStatus("CORRECT");
        private string status;

        private InvoiceCreateStatus(string status)
        {
            this.status = status;
        }
    }
}