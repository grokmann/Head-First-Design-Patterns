using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State.States
{
    public class HasQuarterState : BaseState, IState
    {
        public HasQuarterState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }
        
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Your quarter has been returned.");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned..."); 
            gumballMachine.SetState(gumballMachine.GetSoldState());
            gumballMachine.dispense(); 
        }

        public void Dispense()
        {
            Console.WriteLine("You haven't turned the crank.");
        }
    }
}
