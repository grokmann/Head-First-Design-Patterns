using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State.States
{
    public class HasQuarterState : IState
    {
        Random randomWinner = new Random(DateTime.Now.Millisecond);
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if ((winner == 0) && (gumballMachine.GetCount() > 1))
            {
                gumballMachine.SetState(gumballMachine.GetWinnerState());
            }
            else {
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
