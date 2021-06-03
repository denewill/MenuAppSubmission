using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SaleInvoice
    {
        private int _InvoiceID;
        private Order _order;
        private PaymentMethod _PaymentMethod;

        public SaleInvoice(int InvoiceID, Order order, PaymentMethod PayMethod)
        {
            _InvoiceID = InvoiceID;
            _order = order;
            _PaymentMethod = PayMethod;
        }
        
        public bool AreYou (int InvoiceID)
        {
            return (_InvoiceID == InvoiceID);
        }

        //PRINTS INVOICE
        public string PrintInvoice ()
        {
            string text = String.Empty;
            if (_order.GetItemOrdered.Count != 0)
            {
                text = "\n ORDER INVOICE"
                + "\n Invoice ID: " + _InvoiceID
                + "\n ============================================================== \n";
                foreach (Item item in _order.GetItemOrdered)
                {
                    text = text + " " + (_order.GetItemOrdered.IndexOf(item) + 1) + ". " + item.GetItemName + "\n $" + item.GetItemPrice + "\n \n";
                }
                text = text + " TOTAL: $" + _order.GetTotalPrice() + "\n \n \n";
            }
            else
            {
                text = "There are no invoices to be printed. \n";
            }
            return text;
        }

        //PROCESS PAYMENT
        public string ProcessPayment (string PaymentDetails)
        {
            return _PaymentMethod.Pay(_order, PaymentDetails);
        }

    }
}
