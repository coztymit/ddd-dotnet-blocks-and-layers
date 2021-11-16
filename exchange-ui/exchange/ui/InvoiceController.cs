using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exchange_application.exchange.accounting.application;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace exchange_ui.exchange.ui
{
    //Controller jest odpowiedzialny za przyjmowania rządań sieciowych
    // 
    [ApiController]
    [Route("invoice")]
    public class InvoiceController : ControllerBase
    {
        private IInvoiceApplicationService invoiceApplicationService;

        public InvoiceController(IInvoiceApplicationService invoiceApplicationService)
        {
            this.invoiceApplicationService = invoiceApplicationService;
        }

        //TWORZY FAKTURE O LOSOWYM NUMERZE
        //localhost:5000/invoice
        //przyklad localhost:5000/invoice/

        public String CreateInvoice()
        {
            return invoiceApplicationService.CreateInvoice().ToString();

        }

        //TWORZY FAKTURE O PODANYM NUMERZE 
        //localhost:5000/invoice/{numerfaktury}
        //przyklad  localhost:5000/invoice/78d6eb0a-449f-4dc5-a511-d046e685af61
        //Guid musi być w poprawnej formie

        [HttpGet("{number}")]
        public String CreateInvoice(string number)
        {
            return invoiceApplicationService.CreateInvoice(number).ToString();
        }
    }
}
