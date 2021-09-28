using System;
using System.Diagnostics;
using currency_exchange.exchange.accounting.application;

namespace currency_exchange.exchange.accounting.infrastructure
{
    public class RestNotificationSender : NotificationSender
    {
        public RestNotificationSender()
        {
        }

        public void sendNotification(string invoiceNumber)
        {
            Debug.WriteLine("Rest: " + invoiceNumber);
        }
    }
}
