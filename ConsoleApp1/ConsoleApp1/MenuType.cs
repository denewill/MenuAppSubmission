using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class MenuType
    {
        public abstract int GetMenuID {get; set;}
        public abstract string GetMenuType {get; set;}
        public abstract string AddItemToMenu(Item item);
        public abstract Item GetItemFromMenu(int ItemID);
        public abstract string DeleteItemFromMenu(int ItemID);
        public abstract bool AreYou(int MenuID);
        public abstract string ShowMenu();
        public abstract int CountMenuItems();
    }
}
