namespace itmdevlabs_currency_exchange.exchange.accounting.domain
{
    internal class Buyer
    {
        private string companyName;
        private string firstName;
        private string lastName;
        private NIP nip;

        public Buyer(string companyName, string firstName, string lastName, NIP nip)
        {
            this.companyName = companyName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nip = nip;
        }

    }
}