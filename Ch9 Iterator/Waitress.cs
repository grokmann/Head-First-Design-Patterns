using System;
using System.Collections;
using System.Collections.Generic;

namespace Ch9_Iterator
{
    public class Waitress : IWaitress
    {
        IList<Menu> menus;

        public Waitress(IList<Menu> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            IList<Menu> menuIterator = menus;

            foreach (var menu in menus)
            {
                PrintMenu(menu.CreateIterator());
            }
        }

        private void PrintMenu(Iterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }

        public bool IsItemVegetarian(string name)
        {
            throw new NotImplementedException();
        }

        public void PrintBreakfastMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintLunchMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintVegetarianMenu()
        {
            throw new NotImplementedException();
        }
    }
}
