using System;
using System.Collections.Generic;
using exchange_domain.exchange.accounting.domain.policy;

namespace exchange_domain.exchange.accounting.domain
{
    public class InvoiceFactory
    {
        public Invoice CreateInvoice(List<IPosiionAttributes> possitionAttributes)
        {
            Seller seller;
            Buyer buyer;
            PreparSellerAndBayer(out seller, out buyer);

            Invoice invoice = new Invoice(seller, buyer);

            return PrepareInvoice (possitionAttributes, invoice);
        }

        public Invoice CreateInvoice(string number, List<IPosiionAttributes> possitionAttributes)
        {

            Seller seller;
            Buyer buyer;
            PreparSellerAndBayer(out seller, out buyer);

            Invoice invoice = new Invoice(new Number(number), seller, buyer);

            return PrepareInvoice(possitionAttributes, invoice);
        }

        public Invoice CreateInvoice(List<IPosiionAttributes> possitionAttributes, IPositionLimitPolicy limitPolicy)
        {

            //TO dla przyspeiszenie 
            Seller seller = new Seller("Coztymit", "Jan", "Kowalski", new NIP());
            Buyer buyer = new Buyer("Coztymit", "Jan", "Kwiatkowski", new NIP());

            //Czy nie łamiemy tu wprowadznai agregatu w nieodpowieni stan? 
            Invoice invoice = new Invoice(seller, buyer);

            return PrepareInvoice(possitionAttributes, invoice);
        }

        private static Invoice PrepareInvoice(List<IPosiionAttributes> possitionAttributes, Invoice invoice)
        {
            //okresl polityke ilosci pozycji
            IPositionLimitPolicy limitPolicy = new PLNPositionLimitPolicy();

            possitionAttributes.ForEach(pos =>
                            invoice.AddPosition(
                                    new Position(new ProductNumber(pos.ProductNumber()), new Money(pos.ProductValue())),
                                    limitPolicy
                                )
                            );
            return invoice;
        }

        private static void PreparSellerAndBayer(out Seller seller, out Buyer buyer)
        {
            //TO dla przyspeiszenie 
            seller = new Seller("Coztymit", "Jan", "Kowalski", new NIP());
            buyer = new Buyer("Coztymit", "Jan", "Kwiatkowski", new NIP());
        }

    }
}
