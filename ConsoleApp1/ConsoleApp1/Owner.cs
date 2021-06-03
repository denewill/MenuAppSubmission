using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Owner
    {
        private int _OwnerID;
        private string _OwnerName;
        private Restaurant _restaurant;
        private ItemList _item;
        private MenuList _menu;
        private Report _report;

        public Owner (int OwnerID, string OwnerName)
        {
            _OwnerID = OwnerID;
            _OwnerName = OwnerName;
            _restaurant = Restaurant.GetRestaurant;
            _item = ItemList.GetItemList;
            _menu = MenuList.GetMenuList;
            _report = Report.GetReport;
        }


        //GET SET METHODS FOR CLASS KNOWLEDGE
        public int GetOwnerID
        {
            get { return _OwnerID; }
            set { _OwnerID = value; }
        }

        public string GetOwnerName
        {
            get { return _OwnerName; }
            set { _OwnerName = value; }
        }


        //CRUD STAFF
        public string CreateWaiter(int StaffID, string StaffName, string StaffPhone)
        {
            _restaurant.CreateWaiter(new Waiter(StaffID, StaffName, StaffPhone));
            return ("New Waiter " + StaffName + " has joined the team!");
        }

        public string CreateChef(int StaffID, string StaffName, string StaffPhone)
        {
            _restaurant.CreateChef(new Chef(StaffID, StaffName, StaffPhone));
            return ("New Chef " + StaffName + " has joined the team!");
        }

        public int NumberOfStaff()
        {
            return _restaurant.NumberOfStaff;            
        }

        public Staff GetStaff (int StaffID)
        {
            return _restaurant.GetStaff(StaffID);
        }

        public string ChangeStaff (int OldStaffID, int NewStaffID, string NewStaffName, string NewStaffPhone)
        {
            _restaurant.ChangeStaff(OldStaffID, NewStaffID, NewStaffName, NewStaffPhone);
            return ("\n Staff details has just been updated: \n" 
                + "\n Staff ID:    " + NewStaffID
                + "\n Staff Name:  " + NewStaffName 
                + "\n Staff Phone: " + NewStaffPhone + " \n \n");
        }

        public string DeleteStaff (int StaffID)
        {
            string text = (GetStaff(StaffID).GetStaffName) + " is leaving.. Take care!";
            _restaurant.DeleteStaff(StaffID);
            return text;
        }

        
        //CRUD ITEM
        public string CreateItem (int ItemID, string ItemName, string ItemDetail, double ItemPrice)
        {
            Item item = new Item(ItemID, ItemName, ItemDetail, ItemPrice);
            return _item.AddItem(item);            
        }

        public string ChangeItem (int OldItemID, int NewItemID, string NewItemName, string NewItemDetail, double NewItemPrice)
        {
            return _item.ChangeItem(OldItemID, NewItemID, NewItemName, NewItemDetail, NewItemPrice);
        }

        public Item GetItem (int ItemID)
        {
           return _item.GetItem(ItemID);
        }

        public string DeleteItem (int ItemID)
        {
            return _item.DeleteItem(ItemID);
        }

        public int NumberOfItem ()
        {
            return _item.NumberOfItem();
        }

        
        //CRUD MENU
        public string CreateInStoreMenu(int MenuID)
        {
            _menu.AddMenu(new InStoreMenu(MenuID));
            return "In-Store Menu created";
        }

        public string CreateTakeawayMenu(int MenuID)
        {
            _menu.AddMenu(new TakeawayMenu(MenuID));
            return "Takeaway Menu created";
        }

        public MenuType GetMenu (int MenuID)
        {
            return _menu.GetMenu(MenuID);
        }

        public string AddItemstoMenu(Item item, int MenuID)
        {
            MenuType menu = GetMenu(MenuID);
            return menu.AddItemToMenu(item);            
        }

        public string DeleteItemFromMenu(int ItemID, int MenuID)
        {
            return GetMenu(MenuID).DeleteItemFromMenu(ItemID);
        }

        public string DeleteMenu(int MenuID)
        {
            return _menu.DeleteMenu(MenuID);
        }

        public int NumberOfMenu()
        {
            return _menu.NumberOfMenu();
        }


        //ACCESS REPORT
        public string ReviewReport ()
        {
            return _report.ReportSales();
        }
    }
}
