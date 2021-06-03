using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class StatusDetail
    {
        private DateTime _OrderPlacedTime;
        private TimeSpan _TimeElapsed;

        public StatusDetail()
        {
            _OrderPlacedTime = DateTime.Now;
            _TimeElapsed = _OrderPlacedTime - DateTime.Now;
        }

        //SHOW STATUS DETAIL
        public string GetStatusDetail ()
        {            
            string text = string.Empty;
            text = "Order was placed on " + _OrderPlacedTime + ". \n Time elapsed: " + _TimeElapsed.ToString() + "\n \n";
            if (_TimeElapsed.Minutes > 30)
            {
                text = text + "The customers have been waiting for more than 30 minutes. \n" +
                    "Please apologize to the customers and serve them ASAP. \n \n \n";
            }
            else if (_TimeElapsed.Minutes > 15)
            {
                text = text + "The customers have been waiting for more than 15 minutes. \n" +
                    "Please provide customers with refreshments and serve them ASAP. \n \n \n";
            }
            else
            {
                text = text + "Please make sure customers are comfy and happy. \n \n \n";
            }
            return text;
        }

        //GET SET METHODS FOR CLASS KNOWLEDGE
        public string GetOrderPlacedTime
        {
            get { return _OrderPlacedTime.ToString(); }
        }

        public string GetTimeElapsed
        {
            get { return _TimeElapsed.ToString(); }
        }
    }
}
