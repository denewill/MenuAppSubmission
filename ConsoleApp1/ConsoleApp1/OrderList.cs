using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class OrderList
    {
        private static OrderList instance = null;
        private static readonly object padlock = new object();
        private List<Order> _order;

        OrderList()
        {
            _order = new List<Order>();
        }

        public static OrderList GetOrderList
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new OrderList();
                    }
                    return instance;
                }
            }
        }

        public void AddOrder(Order order)
        {
            _order.Add(order);
        }

        public void ChangeOrder(int OldOrderID, int NewOrderID, string NewCustomerName)
        {
            Order order = GetOrder(OldOrderID);
            order.GetOrderID = NewOrderID;
            order.GetCustomerName = NewCustomerName;
        }

        public Order GetOrder(int OrderID)
        {
            foreach (Order order in _order)
            {
                if (order.AreYou(OrderID))
                {
                    return order;
                }
            }
            return null;
        }

        public string ReadOrder(int OrderID)
        {
            if (GetOrder(OrderID) != null)
            {
                return GetOrder(OrderID).ReadOrder();
            }
            return "OrderID invalid. Please check OrderID and try again.";
        }


        public string ReadAllOrders()
        {
            string text = string.Empty;
            if (_order.Count != 0)
            {
                foreach (Order order in _order)
                {
                    text = text + order.ReadOrder();                    
                }
            }
            else
            {
                text = "No orders available at the moment. ";
            }

            return text;
        }

        public List<Order> GetListofOrder 
        {
            get { return _order;  }
        }

        public void DeleteOrder(int OrderID)
        {
            _order.Remove(GetOrder(OrderID));
        }

        public int NumberOfOrder()
        {
            return _order.Count;
        }
    }
}
