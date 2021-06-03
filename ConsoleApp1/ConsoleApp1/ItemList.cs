using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ItemList
    {
        private static ItemList instance = null;
        private static readonly object padlock = new object();
        private List<Item> _items;

        ItemList()
        {
            _items = new List<Item>();
        }

        public static ItemList GetItemList
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ItemList();
                    }
                    return instance;
                }
            }
        }

        public string AddItem (Item item)
        {
            if (!(_items.Contains(item)))
            {
                _items.Add(item);
                return (item.GetItemName + " has been created and is now good for sale!");
            }
            return "There is already the same item in the inventory.";
        }

        public string ChangeItem(int OldItemID, int NewItemID, string NewItemName, string NewItemDetail, double NewItemPrice)
        {
            if (_items.Contains(GetItem(OldItemID)))
            {
                Item item = GetItem(OldItemID);
                item.GetItemID = NewItemID;
                item.GetItemName = NewItemName;
                item.GetItemDetail = NewItemDetail;
                item.GetItemPrice = NewItemPrice;
                return ("\n The item has been updated: \n" 
                    + "\n Item ID: " + NewItemID
                    + "\n Item Name: " + NewItemName
                    + "\n Item Detail: " + NewItemDetail
                    + "\n Item Price : " + NewItemPrice + " \n \n ");            
            }
            return "This item is not in the inventory, thus it cannot be changed";
            
        }

        public Item GetItem(int ItemID)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(ItemID))
                {
                    return item;
                }
            }
            return null;
        }

        public string DeleteItem (int ItemID)
        {
            if (_items.Contains(GetItem(ItemID)))
            {
                _items.Remove(GetItem(ItemID));
                return "The item has been removed.";
            }
            return "The item cannot be removed because it is not in yhe inventory.";
        }

        public int NumberOfItem ()
        {
            return _items.Count;
        }
    }
        
}
