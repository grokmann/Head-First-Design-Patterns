using System;

namespace Ch7_Facade
{
    internal class Screen
    {
        internal void Down()
        {
            Console.WriteLine("Theater Screen going down");
        }

        internal void Up()
        {
            Console.WriteLine("Theater Ceiling going up");
        }
    }
}