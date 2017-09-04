using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State.States
{
    public class SoldOutState : BaseState, IState
    {
        public SoldOutState(GumballMachine gumballMachine) : base(gumballMachine) { }
        
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
