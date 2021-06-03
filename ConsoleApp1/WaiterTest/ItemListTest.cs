using Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace Test
{
    [TestClass]
    public class ItemListTest
    {
        private ItemList _item;
        private Item item1;
        private Item item2;

        [TestInitialize]
        public void ItemListTestInitializer()
        {
            _item = ItemList.GetItemList;
            item1 = new Item(1, "a", "aaa", 4);
            item2 = new Item(2, "b", "bbb", 5);            
        }

        [TestMethod]
        public void AddItemTest()
        {
            _item.AddItem(item1);
            Assert.IsTrue(_item.NumberOfItem() == 1);
        }

        [TestMethod]
        public void DeleteItemTest()
        {
            _item.AddItem(item1);
            _item.DeleteItem(1);
            Assert.IsTrue(_item.NumberOfItem() == 0);
        }
    }
}
