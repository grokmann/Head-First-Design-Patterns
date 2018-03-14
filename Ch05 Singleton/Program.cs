using System;

namespace Ch5_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicSingleton classicSingleton = ClassicSingleton.GetInstance();
            classicSingleton = ClassicSingleton.GetInstance();
            classicSingleton = ClassicSingleton.GetInstance();

            Console.ReadKey();
        }
    }
}
