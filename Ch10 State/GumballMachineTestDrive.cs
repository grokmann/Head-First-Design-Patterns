using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State
{
    public class GumballMachineTestDrive
    {
        public static void RunTests()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine(gumballMachine);
            
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            
            Console.WriteLine(gumballMachine);
            
            gumballMachine.insertQuarter();
            gumballMachine.ejectQuarter();
            gumballMachine.turnCrank();
            
            Console.WriteLine(gumballMachine);
            
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.ejectQuarter();
            
            Console.WriteLine(gumballMachine);
            
            gumballMachine.insertQuarter();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            
            Console.WriteLine(gumballMachine);
        }
    }
}
