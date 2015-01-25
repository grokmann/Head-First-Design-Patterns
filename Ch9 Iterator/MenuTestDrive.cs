using System.Collections.Generic;

namespace Ch9_Iterator
{
    public static class MenuTestDrive
    {
        public static void Run()
        {
            List<Menu> menus = new List<Menu>();
            menus.Add(new PancakeHouseMenu());
            menus.Add(new DinerMenu());
            menus.Add(new CafeMenu());

            Waitress waitress = new Waitress(menus);

            waitress.PrintMenu();
        }
    }
}
