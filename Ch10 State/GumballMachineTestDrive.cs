using System;

namespace Ch10_State
{
    public class GumballMachineTestDrive
    {
        public static void RunTests()
        {
            const string CrLf = "\r\n";

            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine + CrLf);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            
            Console.WriteLine(gumballMachine + CrLf);
            
            gumballMachine.insertQuarter();
            gumballMachine.ejectQuarter();
            gumballMachine.turnCrank();
            
            Console.WriteLine(gumballMachine + CrLf);
            
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.ejectQuarter();

            Console.WriteLine(gumballMachine + CrLf);
        }
    }
}
