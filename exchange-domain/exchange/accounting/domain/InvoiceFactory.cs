using System;
using System.Collections.Generic;
using exchange_domain.exchange.accounting.domain.policy;

namespace exchange_domain.exchange.accounting.domain
{
    public class InvoiceFactory
    {
        public Invoice createInvoice(List<IPosiionAttributes> possitionAttributes)
        {
            Seller seller;
            Buyer buyer;
            PreparSellerAndBayer(out seller, out buyer);

            Invoice invoice = new Invoice(seller, buyer);

            return PrepareInvoice (possitionAttributes, invoice);
        }

        public Invoice createInvoice(String number, List<IPosiionAttributes> possitionAttributes)
        {

            Seller seller;
            Buyer buyer;
            PreparSellerAndBayer(out seller, out buyer);

            Invoice invoice = new Invoice(new Number(number), seller, buyer);

            return PrepareInvoice(possitionAttributes, invoice);
        }

        public Invoice createInvoice(List<IPosiionAttributes> possitionAttributes, IPositionLimitPolicy limitPolicy)
        {

            //TO dla przyspeiszenie 
            Seller seller = new Seller("ITMDevlab", "Jan", "Kowalski", new NIP());
            Buyer buyer = new Buyer("ITMDevlab", "Jan", "Kowalski", new NIP());

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
                                    new Position(new ProductNumber(pos.productNumber()), new Money(pos.productValue())),
                                    limitPolicy
                                )
                            );
            return invoice;
        }

        private static void PreparSellerAndBayer(out Seller seller, out Buyer buyer)
        {
            //TO dla przyspeiszenie 
            seller = new Seller("ITMDevlab", "Jan", "Kowalski", new NIP());
            buyer = new Buyer("ITMDevlab", "Jan", "Kowalski", new NIP());
        }

    }
}
