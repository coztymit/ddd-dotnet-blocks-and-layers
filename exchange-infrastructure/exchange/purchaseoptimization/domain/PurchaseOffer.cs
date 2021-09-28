using System;
using System.Collections.Generic;

namespace currency_exchange.exchange.purchaseoptimization.domain
{
    public class PurchaseOffer
    {
        private OfferedClient offeredClient;
        private List<Promotion> promotions;
        private Negotiation negotiation;

        //TODO refaktor - na VO
        private DateTime expirationDate;

        public PurchaseOffer(){
            promotions = new List<Promotion>();
        }

        void add(Promotion promotion){

            //TODO dodanie promocj jeżeli nie ma już promocji okreslonego typu

            List<Promotion> activePromotions = this.promotions.FindAll(x => x.promoType().Equals("monthly") && x.isActive());
            if (activePromotions.Count == 0)
            {
                this.promotions.Add(promotion);
            }
        }

       Discount findBestDiscount(Currency currency) {
            List<Promotion> activePromotions = this.promotions.FindAll(x => x.promoCurrency().Equals(currency) && x.isActive());

            //posortuj 
            if (activePromotions.Count != 0)
            {
                foreach (Promotion promotion in activePromotions)
                {
                    return promotion.promoDiscount();
                }
            }
            return Discount.ZERO;
       }

    }
}
