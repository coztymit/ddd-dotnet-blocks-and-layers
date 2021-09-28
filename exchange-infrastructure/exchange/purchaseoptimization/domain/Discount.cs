namespace currency_exchange.exchange.purchaseoptimization.domain
{
    public class Discount
    {
        public static Discount ZERO = new Discount(0);
        private int value;

        public Discount(int value)
        {
            this.value = value;
        }
    }
}