using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Card : PaymentMethod
    {
        public override string Pay(Order order, string PaymentDetails)
        {
            string text = "Payment by Card has been accepted.\n $" + order.GetTotalPrice()
                + " has been deducted from the following Card: " + PaymentDetails + ". \n Thank you for your patronage.";
            return text;
        }

    }
}
