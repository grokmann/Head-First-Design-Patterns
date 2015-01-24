namespace Ch9_Iterator
{
    public static class MenuTestDrive
    {
        public static void Run()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();
        }
    }
}
