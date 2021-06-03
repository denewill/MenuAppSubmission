using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class PaymentMethod
    {
        //STRATEGY METHOD
        public abstract string Pay(Order order, string PaymentDetails);
    }
}
