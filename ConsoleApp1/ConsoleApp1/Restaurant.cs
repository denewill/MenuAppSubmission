using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public sealed class Restaurant
    {
        //SINGLETON CLASS
        private static Restaurant instance = null;
        private static readonly object padlock = new object();
        private List<Staff> _staff;
        private string _Name;
        private string _Address;
        private string _Phone;
        
        Restaurant()
        {
            _Name = "Cuddly Wombat";
            _Address = "1 John St, Hawthorn, VIC 3122";
            _Phone = "04123456789";
            _staff = new List<Staff>();
        }
        
        public static Restaurant GetRestaurant
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Restaurant();
                    }
                    return instance;
                }
            }
        }


        //GET SET METHODS FOR CLASS KNOWLEDGE
        public string GetName
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string GetAddress
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string GetPhone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }


        //CRUD Staff
        public void CreateWaiter(Waiter waiter)
        {
            if (!(_staff.Contains(waiter)))
            {
                _staff.Add(waiter);
            }
            
        }

        public void CreateChef(Chef chef)
        {
            if (!(_staff.Contains(chef)))
            {
                _staff.Add(chef);
            }
        }

        public int NumberOfStaff
        {
            get
            {
                return _staff.Count;
            }
        }

        public Staff GetStaff(int StaffID)
        {
            foreach (Staff staff in _staff)
            {
                if (staff.AreYou(StaffID))
                {
                    return staff;
                }
            }
            return null;
        }

        public void ChangeStaff(int OldStaffID, int NewStaffID, string NewStaffName, string NewStaffPhone)
        {
            if (GetStaff(OldStaffID) != null)
            {
                Staff staff = GetStaff(OldStaffID);
                staff.GetStaffID = NewStaffID;
                staff.GetStaffName = NewStaffName;
                staff.GetStaffPhone = NewStaffPhone;
            }            
        }

        public void DeleteStaff(int StaffID)
        {
            if (_staff.Contains(GetStaff(StaffID)))
            {
                _staff.Remove(GetStaff(StaffID));
            }
            
        }

    }
}
