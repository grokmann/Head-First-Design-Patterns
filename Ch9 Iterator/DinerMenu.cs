﻿using System;

namespace Ch9_Iterator
{
    public class DinerMenu
    {
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", 
                "(Fakin') bacon with lettuce & tomato on whole wheat", 
                true, 
                2.99);

            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99);

            AddItem("Soup of the Day",
                "Soup of the day, with a side of potato salad",
                false,
                3.29);

            AddItem("Hotdog",
                "A hotdog, with sauerkraut, relish, onions, topped with cheese",
                false,
                3.05);

            AddItem("Steamed Veggies and Brown Rice",
                            "Steamed vegetables over brown rice",
                            true,
                            3.99);

            AddItem("Pasta",
                            "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                            true,
                            3.89);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems = numberOfItems + 1;
            }
        }

        public Iterator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        //other menu methods here depending on Array implementation
    }
}
