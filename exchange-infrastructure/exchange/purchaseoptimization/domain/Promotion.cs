namespace exchange_infrastructure.exchange.purchaseoptimization.domain
{
     public class Promotion
    {
        private string promotionType;
        private bool active;
        private Currency currency;
        private Discount discount;

        public string promoType()
        {
            return promotionType;
        }

        public bool isActive()
        {
            return active;
        }

        public Currency promoCurrency()
        {
            return currency;
        }
        public Discount promoDiscount()
        {
            return discount;
        }

    }
}