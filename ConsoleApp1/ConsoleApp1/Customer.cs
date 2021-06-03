using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Customer
    {
        private string _CustomerName;
        private int _ReservationNumber;
        private MenuList _Menu;
        private Reservation _reservation;
        private Order _order;

        public Customer (string CustomerName, int ReservationNumber)
        {
            _CustomerName = CustomerName;
            _ReservationNumber = ReservationNumber;
            _Menu = MenuList.GetMenuList;
            _reservation = null;
            _order = null;
        }

        
        //GET SET METHODS FOR CLASS KNOWLEDGE
        public string GetCustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public int GetReservationNumber
        {
            get { return _ReservationNumber; }
            set { _ReservationNumber = value; }
        }


        //READ MENU
        public string ReadMenu()
        {
            string text = string.Empty;
            foreach (MenuType menu in _Menu.GetListofMenu)
            {
                text = text + menu.ShowMenu();
            }
            return text;
        }


        //GET RESERVATION FROM WAITER
        public void GetReservationFromWaiter(Reservation reservation)
        {
            _reservation = reservation;
        }

        //READ RESERVATION
        public string ReadReservation()
        {
            string text = string.Empty;
            if (_reservation == null)
            {
                text = "You have no reservations. ";
            }
            else
            {
                text = _reservation.ReadReservation();
                
            }
            return text;
        }

        //GET ORDER FROM WAITER
        public void GetOrderFromWaiter(Order order)
        {
            _order = order;
        }

        //READ ORDER
        public string ReadOrder()
        {
            string text = string.Empty;
            if (_order == null)
            {
                text = "You have no orders. ";
            }
            else
            {
                text = _order.ReadOrder();

            }
            return text;
        }

        //READ ORDER STATUS
        public string ReadOrderStatus()
        {
            return _order.ReadOrderStatus();
        }
    }
}
