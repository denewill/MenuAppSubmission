using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Staff
    {
        //ABSTRACT CLASS IMPLEMENTED BY CHEF AND WAITER
        public abstract int GetStaffID { get; set; }
        public abstract string GetStaffName { get; set; }
        public abstract string GetStaffPhone { get; set; }
        public abstract string GetStaffType { get; }
        public abstract bool AreYou(int StaffID);
        public abstract Order GetOrder(int OrderID);
    }
}
