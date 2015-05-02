using System.Collections.Generic;

namespace Ch9_Iterator
{
    public static class MenuTestDrive
    {
        public static void Run()
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            // add menu items here

            dinerMenu.Add(new MenuItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89));

            dinerMenu.Add(new MenuItem(
                "Vegetarian BLT",
                "(Fakin') bacon with lettuce & tomato on whole wheat",
                true,
                2.99));

            dinerMenu.Add(new MenuItem(
                "BLT",
                "Bacon with lettuce & tomato on whole wheat",
                false,
                2.99));

            dinerMenu.Add(new MenuItem(
                "Soup of the Day",
                "Soup of the day, with a side of potato salad",
                false,
                3.29));

            dinerMenu.Add(new MenuItem(
                "Hotdog",
                "A hotdog, with sauerkraut, relish, onions, topped with cheese",
                false,
                3.05));

            dinerMenu.Add(new MenuItem(
                "Steamed Veggies and Brown Rice",
                "Steamed vegetables over brown rice",
                true,
                3.99));

            dinerMenu.Add(new MenuItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem(
                "Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla ice cream",
                true,
                1.59));

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintMenu();
        }
    }
}
