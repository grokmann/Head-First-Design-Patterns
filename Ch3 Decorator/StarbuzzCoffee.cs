using System;
using StarbuzzCoffee.Condiments;
using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee
{
    public class StarbuzzCoffee
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Starbuzz Coffee!\n");

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription()
                + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription()
                + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.getDescription()
                + " $" + beverage3.cost());

            Beverage ventiTest = new HouseBlend();
            ventiTest.setSize(Beverage.Size.Venti);
            ventiTest = new Soy(ventiTest);
            ventiTest = new Mocha(ventiTest);
            ventiTest = new Whip(ventiTest);
            Console.WriteLine(ventiTest.getDescription()
                + " $" + ventiTest.cost());

            Beverage changeSizeTest = new HouseBlend();
            changeSizeTest.setSize(Beverage.Size.Venti);
            changeSizeTest = new Soy(changeSizeTest);
            changeSizeTest = new Mocha(changeSizeTest);
            changeSizeTest = new Whip(changeSizeTest);
            Console.WriteLine(changeSizeTest.getDescription()
                + " $" + changeSizeTest.cost());
            changeSizeTest.setSize(Beverage.Size.Grande);
            Console.WriteLine(changeSizeTest.getDescription()
                + " $" + changeSizeTest.cost());

            Console.ReadKey();
        }
    }
}
