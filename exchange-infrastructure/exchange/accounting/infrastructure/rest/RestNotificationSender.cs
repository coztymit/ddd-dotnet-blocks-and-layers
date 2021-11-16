using System;
using System.Diagnostics;
using exchange_application.exchange.accounting.application;

namespace exchange_infrastructure.exchange.accounting.infrastructure.rest
{
    public class RestNotificationSender : NotificationSender
    {
        public RestNotificationSender()
        {
        }

        public void SendNotification(string invoiceNumber)
        {
            Debug.WriteLine("Rest: " + invoiceNumber);
        }
    }
}
