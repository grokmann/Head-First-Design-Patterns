using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State.States
{
    public class SoldState : BaseState, IState
    {
        public SoldState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void Dispense()
        {
            Console.WriteLine("A gumball comes rolling out the slot");
            count = count - 1;
            if (gumballMachine.inventoryCount() > 0)
            {
                gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            }
            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
        }
    }
}
