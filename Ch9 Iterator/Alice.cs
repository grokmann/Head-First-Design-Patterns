using System;
using System.Collections;

namespace Ch9_Iterator
{
    public class Alice : IWaitress
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
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            ArrayList breakfastItems = pancakeHouseMenu.GetMenuItems();

            DinerMenu dinerMenu = new DinerMenu();
            MenuItem[] lunchItems = dinerMenu.GetMenuItems();

            for (int i = 0; i < breakfastItems.Count; i++)
            {
                MenuItem menuItem = (MenuItem)breakfastItems[i];
                Console.Write(menuItem.GetName() + " ");
                Console.WriteLine(menuItem.GetPrice() + " ");
                Console.WriteLine(menuItem.GetDescription() + " ");
            }

            for (int i = 0; i < breakfastItems.Count; i++)
            {
                MenuItem menuItem = lunchItems[i];
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
