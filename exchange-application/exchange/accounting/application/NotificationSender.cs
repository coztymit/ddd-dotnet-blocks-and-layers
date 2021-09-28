using System;
namespace currency_exchange.exchange.accounting.application
{
    public interface NotificationSender
    {
        void sendNotification(String invoiceNumber);
    }
}
