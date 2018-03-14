namespace Ch9_Iterator
{
    public interface IWaitress
    {
        void PrintMenu();

        void PrintBreakfastMenu();

        void PrintLunchMenu();

        void PrintVegetarianMenu();

        bool IsItemVegetarian(string name);
    }
}
