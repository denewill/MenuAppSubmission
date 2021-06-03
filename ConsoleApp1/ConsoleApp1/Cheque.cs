using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Cheque : PaymentMethod
    {
        public override string Pay(Order order, string PaymentDetails)
        {
            string text = "Payment by Cheque has been accepted.\n $" + order.GetTotalPrice()
                + " has been deducted from the following Cheque: " + PaymentDetails + ". \n Thank you for your patronage.";
            return text;
        }
    }
}
