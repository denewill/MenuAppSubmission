using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Waiter : Staff
    {
        private readonly string _StaffType;
        private int _StaffID;
        private string _StaffName;
        private string _StaffPhone;
        private OrderList _order;
        private ReservationList _reservation;
        private ItemList _item;
        private Report _SaleInvoiceList;

        public Waiter(int StaffID, string StaffName, string StaffPhone)
        {
            _StaffID = StaffID;
            _StaffName = StaffName;
            _StaffPhone = StaffPhone;
            _StaffType = "Waiter";
            _order = OrderList.GetOrderList;
            _reservation = ReservationList.GetReservationList;
            _item = ItemList.GetItemList;
            _SaleInvoiceList = Report.GetReport;
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


        //CRUD ORDER
        public string CreateOrder (int OrderID, string CustomerName)
        {
            _order.AddOrder(new Order(OrderID, CustomerName));
            return ("Order with OrderID " + OrderID + " has been created for Customer " + CustomerName + ". ");
        }

        public override Order GetOrder (int OrderID)
        {
            return _order.GetOrder(OrderID);
        }

        public string ReadOrder(int OrderID)
        {
            if (_order.GetOrder(OrderID) != null)
            {
                return _order.ReadOrder(OrderID);
            }
            return "OrderID invalid. Please check OrderID and try again.";
        }

        public string ReadAllOrders()
        {
            return _order.ReadAllOrders();
        }

        public string ChangeOrder(int OldOrderID, int NewOrderID, string NewCustomerName)
        {
            if (_order.GetOrder(OldOrderID) != null)
            {
            _order.ChangeOrder(OldOrderID, NewOrderID, NewCustomerName);
            return ("\n Order with previous OrderID " + OldOrderID + " has been changed to: \n" 
                + " Order ID: " + NewOrderID + " \n"
                + " Customer: " + NewCustomerName + "\n ");
            }
            return "OrderID invalid. Please check OrderID and try again.";
        }

        public string DeleteOrder(int OrderID)
        {
            if (_order.GetOrder(OrderID) != null)
            {
                _order.DeleteOrder(OrderID);
                return ("Order with OrderID " + OrderID + " has been deleted. ");
            }
            return "OrderID invalid. Please check OrderID and try again.";
        }

        public string AddItemsToOrder(int OrderID, int ItemID)
        {
            if (_order.GetOrder(OrderID) != null)
            {
                if (_item.GetItem(ItemID) != null)
                {
                    GetOrder(OrderID).AddItemToOrder(_item.GetItem(ItemID));
                    return (_item.GetItem(ItemID).GetItemName + " has been added to Order " + OrderID + ". \n");
                }
                return "ItemID invalid. Please check ItemID and try again.";
            }
            return "OrderID invalid. Please check OrderID and try again.";
        }

        public string RemoveItemFromOrder(int OrderID, int ItemID)
        {
            if (_order.GetOrder(OrderID) != null)
            {
                if (_item.GetItem(ItemID) != null)
                {
                    GetOrder(OrderID).RemoveItemFromOrder(ItemID);
                    return (_item.GetItem(ItemID).GetItemName + " has been removed from Order " + OrderID + ". \n");
                }
                return "ItemID invalid. Please check ItemID and try again.";
            }
            return "OrderID invalid. Please check OrderID and try again.";            
        }
        
        public int NumberOfOrder()
        {
            return _order.NumberOfOrder();
        }

        public string DeliverOrder (int OrderID)
        {
            if (_order.GetOrder(OrderID) != null)
            {
                if (_order.GetOrder(OrderID).GetOrderStatus == Order.OrderStatus.COOKED)
                {
                    _order.GetOrder(OrderID).OrderStatusDelivered();
                    return "The order is now delivered. Great job!";
                }
                return "The order is not ready for delivery yet. Please wait a few more minutes.";                
            }
            return "OrderID invalid. Please check OrderID and try again.";
        }


        //CRUD RESERVATION
        public string CreateReservation (int ReservationNumber, string ReservationDate, string ReservationTime, string CustomerName, int NumberOfPeople)
        {
            _reservation.AddReservation(new Reservation(ReservationNumber, ReservationDate, ReservationTime, CustomerName, NumberOfPeople));
            return ("\n Reservation created." 
                + "\n Reservation Number: " + ReservationNumber   
                + "\n Reservation Date:   " + ReservationDate
                + "\n Reservation Time:   " + ReservationTime
                + "\n Customer Name:      " + CustomerName
                + "\n Number of People:   " + NumberOfPeople + "\n \n");
        }

        public Reservation GetReservation (int ReservationNumber)
        {
            return _reservation.GetReservation(ReservationNumber);
        }

        public string ReadReservation (int ReservationNumber)
        {
            if (_reservation.GetReservation(ReservationNumber) != null)
            {
                return _reservation.ReadReservation(ReservationNumber);
            }
            return "ReservationID invalid. Please check ReservationID and try again.";
        }

        public string ReadAllReservations()
        {
            return _reservation.ReadAllReservations();
        }

        public string ChangeReservation (int OldReservationNumber, int NewReservationNumber, string NewReservationDate, string NewReservationTime, string NewCustomerName, int NewNumberOfPeople)
        {
            return _reservation.ChangeReservation(OldReservationNumber, NewReservationNumber, NewReservationDate, NewReservationTime, NewCustomerName, NewNumberOfPeople);
        }

        public string DeleteReservation (int ReservationNumber)
        {
            return _reservation.DeleteReservation(ReservationNumber);
        }

        public int NumberOfReservation ()
        {
            return _reservation.NumberOfReservation();
        }

        
        //PROCESS PAYMENT
        public string CreateInvoice (int OrderID, PaymentMethod PayMethod)
        {
            _SaleInvoiceList.AddSalesInvoice(new SaleInvoice(OrderID, _order.GetOrder(OrderID), PayMethod));
            return ("SaleInvoice created for Order " + OrderID + ", paid via " + PayMethod.GetType().Name + ". \n");
           
        }

        public string DeleteInvoice (int OrderID)
        {
            _SaleInvoiceList.DeleteInvoice(OrderID);
            return ("SaleInvoice created for Order " + OrderID + " has been deleted. \n");
        }

        public string PrintInvoice (int OrderID)
        {
            if (_SaleInvoiceList.GetInvoice(OrderID) == null)
            {
                return "No invoice available to bill with. Please create an invoice before billing/payment.";
            }
            return _SaleInvoiceList.GetInvoice(OrderID).PrintInvoice();
        }

        public string AcceptPayment (int OrderID, string PaymentDetails)
        {
            if (_SaleInvoiceList.GetInvoice(OrderID) == null)
            {
                return "No invoice available to bill with. Please create an invoice before billing/payment.";
            }
            return _SaleInvoiceList.GetInvoice(OrderID).ProcessPayment(PaymentDetails);
        }
    }
}
