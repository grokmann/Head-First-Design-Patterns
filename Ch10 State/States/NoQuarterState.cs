using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State.States
{
    public class NoQuarterState : BaseState, IState
    {
        public NoQuarterState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public void InsertQuarter()
        {
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
            Console.WriteLine("You inserted a quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}
