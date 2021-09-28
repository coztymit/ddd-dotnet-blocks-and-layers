namespace exchange_domain.exchange.accounting.domain
{

    //Entity 
    class Position
    {
        //nazwa nie przypadkowa ale nie do realnego systemu
        //pojawił się obcy kontekst - PRODUCT 
        private PositionBusinessId id;
        private ProductNumber productNumber;
        private Money productValue;
       
        internal Position(ProductNumber productNumber, Money productValue)
        {
            id = new PositionBusinessId();
            this.productNumber = productNumber;
            this.productValue = productValue;
        }


        public Money PositionValue()
        {
            return productValue;
        }

        public Money PositionNumber()
        {
            return productValue;
        }
    }
}