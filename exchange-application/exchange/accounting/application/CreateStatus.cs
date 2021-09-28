using System;
namespace exchange_application.exchange.accounting.application
{
    public class CreateStatus
    {
        private string status;
        private string invoiceNumber;


        public static CreateStatus Correct(string number)
        {
            return new CreateStatus("SUCCES", number);
        }

        private CreateStatus(string status, string number)
        {
            this.status = status;
            this.invoiceNumber = number;
        }

        private  CreateStatus(string status)
        {
            this.status = status;
        }

       
        public override string ToString()
        {
            return status+ " numer faktury: "+ invoiceNumber;
        }


    }
}
