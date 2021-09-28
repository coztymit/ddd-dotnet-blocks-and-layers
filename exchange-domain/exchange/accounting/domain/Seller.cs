namespace itmdevlabs_currency_exchange.exchange.accounting.domain
{
    class Seller
    {
        private string companyName;
        private string firstName;
        private string lastName;
        private NIP nip;

        public Seller(string companyName, string firstName, string lastName, NIP nip)
        {
            this.companyName = companyName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nip = nip;
        }

        public override string ToString()
        {
            return companyName + " : " + firstName + " : " +lastName;
        }
    }
}