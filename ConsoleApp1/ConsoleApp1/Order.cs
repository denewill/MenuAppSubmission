using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Order
    {
        public enum OrderStatus
        {
            PLACED,
            PROCESSING,
            COOKED,
            DELIVERED
        }
        private int _OrderID;
        private string _CustomerName;
        private double _TotalPrice;
        private List<Item> _ItemOrdered;
        private OrderStatus _OrderStatus;
        private StatusDetail _StatusDetail;

        public Order (int OrderID, string CustomerName)
        {
            _OrderID = OrderID;
            _CustomerName = CustomerName;
            _TotalPrice = 0;
            _ItemOrdered = new List<Item>();
            _OrderStatus = OrderStatus.PLACED;
            _StatusDetail = new StatusDetail();
        }


        //GET SET METHODS FOR CLASS KNOWLEDGE
        public int GetOrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }

        public string GetCustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        
        public double GetTotalPrice ()
        {
            CalculateTotalPrice();
            return _TotalPrice;
        }

        public int NumberofItemsOrdered ()
        {
            return _ItemOrdered.Count;
        }

        public List<Item> GetItemOrdered
        {
            get { return _ItemOrdered; }
        }

        public OrderStatus GetOrderStatus
        {
            get { return _OrderStatus; }
        }

        public void OrderStatusProcessing ()
        {
            _OrderStatus = OrderStatus.PROCESSING;
        }

        public void OrderStatusCooked()
        {
            _OrderStatus = OrderStatus.COOKED;
        }

        public void OrderStatusDelivered()
        {
            _OrderStatus = OrderStatus.DELIVERED;
        }

        public bool AreYou (int OrderID)
        {
            return (_OrderID == OrderID);
        }

        public Item GetItem (int ItemID)
        {
            foreach (Item item in _ItemOrdered)
            {
                if (item.AreYou(ItemID))
                {
                    return item;
                }
            }
            return null;
        }

        public void CalculateTotalPrice()
        {
            double TotalPrice = 0;
            foreach (Item item in _ItemOrdered)
            {
                TotalPrice = TotalPrice + item.GetItemPrice;
            }
            _TotalPrice = TotalPrice;
        }

        public string ReadOrder()
        {
            CalculateTotalPrice();
            string text = string.Empty;

            text = "\n YOUR ORDER" 
                + "\n Order ID: " + _OrderID
                + "\n STATUS OF THIS ORDER:" + _OrderStatus.ToString()
            + " \n ==============================================================";
            foreach (Item item in _ItemOrdered)
            {
                text = text + "\n " + (_ItemOrdered.IndexOf(item) + 1) + ". " + item.GetItemName + "\n $" + item.GetItemPrice + "\n \n";
            }
            text = text + "\n TOTAL: $" + _TotalPrice + "\n \n \n";
            return text;
        }

        public string ReadOrderStatus()
        {
            string text = "STATUS OF THIS ORDER:" + _OrderStatus.ToString(); ;
            return text;
        }

        public string StatusDetail()
        {
            return _StatusDetail.GetStatusDetail();
        }


        //CREATE INVENTORY WITH ITEMS
        public void AddItemToOrder (Item item)
        {
            _ItemOrdered.Add(item);
        }

        public void RemoveItemFromOrder (int ItemID)
        {
            _ItemOrdered.Remove(GetItem(ItemID));
        }

        

        
    }
}
