using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MenuList
    {
        private static MenuList instance = null;
        private static readonly object padlock = new object();
        private List<MenuType> _menu;

        MenuList()
        {
            _menu = new List<MenuType>();
        }

        public static MenuList GetMenuList
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MenuList();
                    }
                    return instance;
                }
            }
        }

        public void AddMenu(MenuType menu)
        {
            _menu.Add(menu);
        }

        public void ChangeMenu(int OldMenuID, int NewMenuID)
        {
            MenuType menu = GetMenu(OldMenuID);
            menu.GetMenuID = NewMenuID;
        }

        public MenuType GetMenu(int MenuID)
        {
            foreach (MenuType menu in _menu)
            {
                if (menu.AreYou(MenuID))
                {
                    return menu;
                }
            }
            return null;
        }

        public List<MenuType> GetListofMenu
        {
            get { return _menu; }
        }

        public string DeleteMenu(int MenuID)
        {
            if (_menu.Contains(GetMenu(MenuID)))
            {
                _menu.Remove(GetMenu(MenuID));
                return "This menu has been deleted.";
            }
            else
            {
                return "This menu does not exist on the list.";
            }
            
        }

        public int NumberOfMenu()
        {
            return _menu.Count;
        }
    }

}
