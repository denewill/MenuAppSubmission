using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Cash : PaymentMethod
    {

        public override string Pay(Order order, string PaymentDetails)
        {
            string text = "Payment by Cash has been accepted.\n $" + order.GetTotalPrice()
                + " has been accepted by the following Cashier: " + PaymentDetails + ". \n Thank you for your patronage.";
            return text;
        }
    }
}
