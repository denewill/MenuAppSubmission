using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ReservationList
    {
        //SINGLETON CLASS
        private static ReservationList instance = null;
        private static readonly object padlock = new object();
        private List<Reservation> _reservation;

        ReservationList()
        {
            _reservation = new List<Reservation>();
        }

        public static ReservationList GetReservationList
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ReservationList();
                    }
                    return instance;
                }
            }
        }


        //CRUD RESERVATION
        public void AddReservation(Reservation reservation)
        {
            _reservation.Add(reservation);
        }

        public Reservation GetReservation(int ReservationNumber)
        {
            foreach (Reservation reservation in _reservation)
            {
                if (reservation.AreYou(ReservationNumber))
                {
                    return reservation;
                }
            }
            return null;
        }

        public string ReadReservation(int ReservationNumber)
        {
            return GetReservation(ReservationNumber).ReadReservation();
        }

        public string ReadAllReservations()
        {
            string text = string.Empty;
            if (_reservation.Count != 0)
            {
                foreach (Reservation reservation in _reservation)
                {
                    text = text + reservation.ReadReservation();
                }
            }
            else
            {
                text = "There are no reservations at the moment. ";
            }
            return text;
        }

        public string ChangeReservation(int OldReservationNumber, int NewReservationNumber, string NewReservationDate, string NewReservationTime, string NewCustomerName, int NewNumberOfPeople)
        {
            Reservation reservation = GetReservation(OldReservationNumber);
            reservation.GetReservationNumber = NewReservationNumber;
            reservation.GetReservationDate = NewReservationDate;
            reservation.GetReservationTime = NewReservationTime;
            reservation.GetCustomerName = NewCustomerName;
            reservation.GetNumberOfPeople = NewNumberOfPeople;

            return ("Reservation Number " + OldReservationNumber + " has been changed into:" 
                + "Reservation Number: " + NewReservationNumber
                + "Reservation Date:   " + NewReservationDate
                + "Reservation Time:   " + NewReservationTime
                + "Customer Name:      " + NewCustomerName
                + "Number of People:   " + NewNumberOfPeople + "\n \n");
        }

        public string DeleteReservation(int ReservationNumber)
        {
            if (GetReservation(ReservationNumber) != null)
            {
                _reservation.Remove(GetReservation(ReservationNumber));
                return ("Reservation Number " + ReservationNumber + " has been deleted. \n");
            }
            return "ReservationID invalid. Please check Reservation ID and try again.";
        }

        public int NumberOfReservation()
        {
            return _reservation.Count;
        }
    }
}
