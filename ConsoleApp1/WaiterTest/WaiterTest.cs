using Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace Test
{
    [TestClass]
    public class WaiterTest
    {
        Owner owner1;
        ItemList itemlist;
        Waiter waiter1;
        Waiter waiter3;

        [TestInitialize]
        public void WaiterTestInitializer()
        {
            owner1 = new Owner(1, "NaPD");
            itemlist = ItemList.GetItemList;
            owner1.CreateItem(1, "Pizza", "Freshly baked New York Pizza", 10.5);
            owner1.CreateItem(2, "Cheesecake", "Freshly served New York Cheesecake", 7.5);
            owner1.CreateWaiter(1, "Yoon", "0452623951");
            waiter1 = new Waiter(2, "Mino", "0452623952");
            owner1.CreateWaiter(3, "Hoon", "0452623953");
            waiter3 = ((owner1.GetStaff(3)) as Waiter);
        }

        [TestMethod]
        public void WaiterIdentifiableTest()
        {
            Assert.IsTrue(owner1.GetStaff(1).GetStaffName == "Yoon");
            Assert.IsTrue(owner1.GetStaff(1).GetStaffType == "Waiter");
        }

        [TestMethod]
        public void WaiterCreateOrderTest()
        {
            waiter1.CreateOrder(1, "Lime");
            Assert.IsTrue(waiter1.GetOrder(1).GetCustomerName == "Lime");
        }

        [TestMethod]
        public void WaiterChangeOrderTest()
        {
            waiter1.CreateOrder(1, "Sam");
            waiter1.ChangeOrder(1, 1, "Lime");
            Assert.IsTrue(waiter1.GetOrder(1).GetCustomerName == "Lime");
        }

        [TestMethod]
        public void WaiterDeleteOrderTest()
        {
            waiter1.CreateOrder(1, "Lime");
            waiter1.DeleteOrder(1);
            Assert.IsTrue(waiter1.NumberOfOrder() == 0);
        }

        [TestMethod]
        public void WaiterCreateReservationTest()
        {
            waiter3.CreateReservation(1, "200220", "15:00", "Lime", 4);
            Assert.IsTrue(waiter3.NumberOfReservation() == 1);
        }

        [TestMethod]
        public void WaiterChangeReservationTest()
        {
            waiter3.CreateReservation(1, "200220", "15:00", "Lime", 4);
            waiter3.ChangeReservation(1, 1, "200220", "15:00", "Lime", 5);
            Assert.IsTrue(waiter3.GetReservation(1).GetNumberOfPeople == 5);
        }

        [TestMethod]
        public void WaiterDeleteReservationTest()
        {
            waiter3.CreateReservation(1, "200220", "15:00", "Lime", 4);
            waiter3.DeleteReservation(1);
            Assert.IsTrue(waiter3.NumberOfReservation() == 0);
        }
    }
}
