﻿using System;
using System.Collections;

namespace Ch9_Iterator
{
    public class Waitress : IWaitress
    {
        Menu pancakeHouseMenu;
        Menu dinerMenu;
        Menu cafeMenu;

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu, Menu cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            Iterator<MenuItem> pancakeIterator = pancakeHouseMenu.CreateIterator();
            Iterator<MenuItem> dinerIterator = dinerMenu.CreateIterator();
            Iterator<MenuItem> cafeIterator = cafeMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
            Console.WriteLine("\nDINNER");
            PrintMenu(cafeIterator);
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