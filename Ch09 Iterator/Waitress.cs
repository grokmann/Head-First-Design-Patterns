using System;
using System.Collections;
using System.Collections.Generic;

namespace Ch9_Iterator
{
    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }
    }
}
