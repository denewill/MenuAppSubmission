using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Reservation
    {
        private int _ReservationNumber;
        private string _ReservationDate;
        private string _ReservationTime;
        private string _CustomerName;
        private int _NumberOfPeople;

        public Reservation (int ReservationNumber, string ReservationDate, string ReservationTime, string CustomerName, int NumberOfPeople)
        {
            _ReservationNumber = ReservationNumber;
            _ReservationDate = ReservationDate;
            _ReservationTime = ReservationTime;
            _CustomerName = CustomerName;
            _NumberOfPeople = NumberOfPeople;
        }

        //GET SET METHODS FOR CLASS KNOWLEDGE
        public int GetReservationNumber
        {
            get { return _ReservationNumber; }
            set { _ReservationNumber = value;  }
        }

        public string GetReservationDate
        {
            get { return _ReservationDate; }
            set { _ReservationDate = value; }
        }

        public string GetReservationTime
        {
            get { return _ReservationTime; }
            set { _ReservationTime = value; }
        }

        public string GetCustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        public int GetNumberOfPeople
        {
            get { return _NumberOfPeople; }
            set { _NumberOfPeople = value; }
        }

        public bool AreYou (int ReservationNumber)
        {
            return (_ReservationNumber == ReservationNumber);
        }

        public string ReadReservation ()
        {
            string text = string.Empty;
            text = text 
                + " Reservation Number: " + _ReservationNumber
                + "\n Reservation Date:   " + _ReservationDate
                + "\n Reservation Time:   " + _ReservationTime
                + "\n Customer Name:      " + _CustomerName
                + "\n Number of People:   " + _NumberOfPeople + "\n \n";
            return text;
        }
    }
}
