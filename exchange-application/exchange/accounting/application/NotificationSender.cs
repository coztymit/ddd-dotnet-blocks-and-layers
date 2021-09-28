using System;
namespace exchange_application.exchange.accounting.application
{
    public interface NotificationSender
    {
        void sendNotification(String invoiceNumber);
    }
}
