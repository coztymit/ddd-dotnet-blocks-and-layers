using System;
using System.Diagnostics;
using exchange_application.exchange.accounting.application;

namespace eexchange_infrastructure.exchange.accounting.infrastructure.rest
{
    public class RabbitNotificationSender : NotificationSender
    {
        public RabbitNotificationSender()
        {
        }

        public void sendNotification(string invoiceNumber)
        {
            Debug.WriteLine("Rabbit: " + invoiceNumber);
        }
    }
}
