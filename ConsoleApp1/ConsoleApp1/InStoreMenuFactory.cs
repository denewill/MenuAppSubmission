using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class InStoreMenuFactory : MenuTypeFactory
    {
        public InStoreMenuFactory()
        { }

        public override MenuType GetMenu(int MenuID)
        {
            return new InStoreMenu(MenuID);
        }
    }
}
