using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Chef : Staff
    {
        private readonly string _StaffType;
        private int _StaffID;
        private string _StaffName;
        private string _StaffPhone;
        private OrderList _order;

        public Chef(int StaffID, string StaffName, string StaffPhone)
        {
            _StaffID = StaffID;
            _StaffName = StaffName;
            _StaffPhone = StaffPhone;
            _StaffType = "Chef";
            _order = OrderList.GetOrderList;
        }

        //GET SET METHODS FOR CLASS KNOWLEDGE
        public override int GetStaffID
        {
            get { return _StaffID; }
            set { _StaffID = value; }
        }

        public override string GetStaffName
        {
            get { return _StaffName; }
            set { _StaffName = value; }
        }

        public override string GetStaffPhone
        {
            get { return _StaffPhone; }
            set { _StaffPhone = value; }
        }

        public override string GetStaffType
        {
            get { return _StaffType; }
        }

        public override bool AreYou(int StaffID)
        {
            return (_StaffID == StaffID);
        }


        //READ ORDER
        public override Order GetOrder(int OrderID)
        {
            return _order.GetOrder(OrderID);
        }

        public string ReadOrder()
        {
            string text = string.Empty;
            if (_order.GetListofOrder.Count != 0)
            {
                foreach (Order order in _order.GetListofOrder)
                {
                    if ((order.GetOrderStatus != Order.OrderStatus.DELIVERED) && (order.GetOrderStatus != Order.OrderStatus.COOKED))
                    {
                        text = text + order.ReadOrder();
                    }
                }
            }
            else
            {
                text = "You have no orders. ";
            }
            
            return text;
        }

        //FULFILL ORDER
        public string CookOrder (int OrderID)
        {
            if (_order.GetOrder(OrderID) != null)
            {
                if (_order.GetOrder(OrderID).GetItemOrdered.Count != 0)
                {
                    _order.GetOrder(OrderID).OrderStatusProcessing();
                    return ("Order with OrderID " + OrderID + " is now being cooked. \n");
                }
                return "Order is empty. Please add items to the other.";
            }
            return "OrderID invalid. Please check the OrderID and try again. \n";
        }

        public string FinishCookingOrder (int OrderID)
        {
            if (_order.GetOrder(OrderID) != null)
            {
                if (_order.GetOrder(OrderID).GetItemOrdered.Count != 0)
                {
                    _order.GetOrder(OrderID).OrderStatusCooked();
                    return "Order with OrderID " + OrderID + " has been cooked. Please call the Waiters to deliver the order. \n";
                }
                return "Order is empty. Please add items to the other.";
            }
            return "OrderID invalid. Please check the OrderID and try again. \n";
        }
    }
}
