using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TakeawayMenu : MenuType
    {
        private int _MenuID;
        private List<Item> _item;
        private string _MenuType;

        public TakeawayMenu(int MenuID)
        {
            _MenuID = MenuID;
            _item = new List<Item>();
            _MenuType = "Takeaway Menu";
        }

        //GET SET METHODS FOR CLASS KNOWLEDGE
        public override int GetMenuID
        {
            get { return _MenuID; }
            set { _MenuID = value; }
        }

        public override string GetMenuType
        {
            get { return _MenuType; }
            set { _MenuType = value; }
        }

        public override bool AreYou(int MenuID)
        {
            return (_MenuID == MenuID);
        }

        public override string ShowMenu ()
        {
            string text = string.Empty;

            text = "TAKEAWAY MENU" + " \n ==============================================================";
            foreach (Item item in _item)
            {
                text = text + item.GetItemID + ". \n" + item.GetItemName + "\n" + item.GetItemDetail + "\n $" + item.GetItemPrice + "\n \n \n";
            }

            return text;
        }

        public override int CountMenuItems()
        {
            return _item.Count;
        }


        //CREATE INVENTORY WITH ITEMS
        public override string AddItemToMenu(Item item)
        {
            if (_item.Contains(item))
            {
                return "This item is already in the menu.";
            }
            else
            {
                _item.Add(item);
            }
            return "This item is added into the menu";
        }

        public override Item GetItemFromMenu(int ItemID)
        {
            foreach (Item item in _item)
            {
                if (item.AreYou(ItemID))
                {
                    return item;
                }
            }
            return null;
        }

        public override string DeleteItemFromMenu(int ItemID)
        {
            if (_item.Contains(GetItemFromMenu(ItemID)))
            {
                _item.Remove(GetItemFromMenu(ItemID));
                return "This item is removed from the menu.";
            }
            else
            {
                return "This item is not in the menu.";
            }            
        }

    }
}
