using Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace Test
{
    [TestClass]
    public class OwnerTest
    {
        private Owner owner1;

        [TestInitialize]
        public void OwnerTestInitializer()
        {
            owner1 = new Owner(1, "Pikachu");
        }

        [TestMethod]
        public void OwnerIdentifiableTest()
        {
            Assert.IsTrue(owner1.GetOwnerName == "Pikachu");
        }

        [TestMethod]
        public void OwnerCreateWaiterTest()
        {
            owner1.CreateWaiter(1, "Yoon", "0452623951");
            Assert.IsTrue(owner1.GetStaff(1).GetStaffID == 1);
            Assert.IsTrue(owner1.NumberOfStaff() == 1);
        }

        [TestMethod]
        public void OwnerChangeStaffTest()
        {
            owner1.CreateChef(1, "Yoon", "0452623951");
            owner1.ChangeStaff(1, 1, "Mino", "0452623952");
            Assert.IsTrue(owner1.GetStaff(1).GetStaffName == "Mino");
            Assert.IsTrue(owner1.NumberOfStaff() == 1);
        }

        [TestMethod]
        public void OwnerDeleteStaffTest()
        {
            //owner1.CreateWaiter(1, "Yoon", "0452623951");
            //owner1.DeleteStaff(1);
            //Assert.IsTrue(owner1.NumberOfStaff() == 0);
        }

        [TestMethod]
        public void OwnerCreateItemTest()
        {
            Item ricecake = new Item(1, "ricecake", "yum", 3.5);
            Assert.IsTrue(ricecake.AreYou(1));
            owner1.CreateItem(1, "a", "aaa", 3.5);
            Assert.IsTrue(owner1.GetItem(1).AreYou(1));
        }

        [TestMethod]
        public void OwnerChangeItemTest()
        {
            owner1.CreateItem(1, "a", "aaa", 3.5);
            owner1.ChangeItem(1, 1, "b", "bbb", 4.5);
            Assert.IsTrue(owner1.GetItem(1).GetItemName == "b");
        }

        [TestMethod]
        public void OwnerDeleteItemTest()
        {
            owner1.CreateItem(1, "a", "aaa", 3.5);
            owner1.CreateItem(2, "b", "bbb", 4.5);
            owner1.DeleteItem(1);
            Assert.IsTrue(owner1.NumberOfItem() == 1);
        }

        [TestMethod]
        public void OwnerCreateMenuTest()
        {
            owner1.CreateItem(1, "Onigiri", "A Japanese riceball wrapped in seaweed", 3.5);
            owner1.CreateItem(2, "Tteokbokki", "Korean ricecake dish with Busan fish cake", 4.5);
            owner1.CreateInStoreMenu(1);
            owner1.CreateTakeawayMenu(2);

            Assert.IsTrue(owner1.GetMenu(1).GetMenuType == "In-Store Menu");
            Assert.IsTrue(owner1.GetMenu(2).GetMenuType == "Takeaway Menu");
        }

        [TestMethod]
        public void OwnerAddItemToMenu()
        {
            Item ricecake = new Item(1, "ricecake", "yum", 3.5);
            owner1.CreateInStoreMenu(1);
            owner1.AddItemstoMenu(ricecake, 1);
            Assert.IsTrue(owner1.GetMenu(1).CountMenuItems() == 1);
        }

        [TestMethod]
        public void OwnerDeleteItemFromMenu()
        {
            Item ricecake = new Item(1, "ricecake", "yum", 3.5);
            owner1.CreateInStoreMenu(1);
            owner1.AddItemstoMenu(ricecake, 1);
            owner1.DeleteItemFromMenu(1, 1);
            Assert.IsTrue(owner1.GetMenu(1).CountMenuItems() == 0);
        }

        [TestMethod]
        public void OwnerDeleteMenuTest()
        {
            owner1.CreateInStoreMenu(1);
            owner1.DeleteMenu(1);
            Assert.IsTrue(owner1.NumberOfMenu() == 0);
        }
    }
}
