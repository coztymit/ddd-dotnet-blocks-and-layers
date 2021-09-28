using System;
using System.Diagnostics;
using currency_exchange.exchange.accounting.application;

namespace currency_exchange.exchange.accounting.infrastructure
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
