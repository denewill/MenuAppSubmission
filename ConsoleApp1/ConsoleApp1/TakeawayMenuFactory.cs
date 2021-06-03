using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TakeawayMenuFactory : MenuTypeFactory
    {
        public TakeawayMenuFactory()
        { }

        public override MenuType GetMenu(int MenuID)
        {
            return new TakeawayMenu(MenuID);
        }
    }
}
