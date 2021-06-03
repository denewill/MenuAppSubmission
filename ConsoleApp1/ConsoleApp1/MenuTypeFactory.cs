using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //CREATOR
    public abstract class MenuTypeFactory 
    {
        public abstract MenuType GetMenu(int MenuID);
    }
}
