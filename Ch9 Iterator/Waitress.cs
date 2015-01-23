using System;
using System.Collections;

namespace Ch9_Iterator
{
    public class Waitress : IWaitress
    {
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

        public void PrintMenu()
        {
            PancakeHouseMenu breakfastMenu= new PancakeHouseMenu();
            DinerMenu lunchMenu = new DinerMenu();

            Iterator breakfastItems = breakfastMenu.CreateIterator();
            Iterator lunchItems = lunchMenu.CreateIterator();

            while (breakfastItems.HasNext())
            {
                MenuItem menuItem = breakfastItems.Next();
                Console.Write(menuItem.GetName() + " ");
                Console.WriteLine(menuItem.GetPrice() + " ");
                Console.WriteLine(menuItem.GetDescription() + " ");
            }

            while (lunchItems.HasNext())
            {
                MenuItem menuItem = lunchItems.Next();
                Console.Write(menuItem.GetName() + " ");
                Console.WriteLine(menuItem.GetPrice() + " ");
                Console.WriteLine(menuItem.GetDescription() + " ");
            }
        }

        public void PrintVegetarianMenu()
        {
            throw new NotImplementedException();
        }
    }
}
