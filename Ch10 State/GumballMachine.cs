using Ch10_State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State
{
    public class GumballMachine
    {
        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;

        IState state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState =  new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            
            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void insertQuarter()
        {
            state.InsertQuarter();
        }

        public void ejectQuarter()
        {
            state.EjectQuarter();
        }

        public void turnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void dispense()
        {
            if (state == SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                count = count - 1;
                if (count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    state = SOLD_OUT;
                }
                else
                {
                    state = NO_QUARTER;
                }
            }

        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Mighty Gumball, Inc.");
            builder.AppendLine("C-Sharp-enabled Standing Gumball Model #2015");
            builder.AppendFormat("Inventory: {0} gumballs\r\n", count);
            if (state == SOLD_OUT) { builder.AppendLine("Machine is sold out"); }
            else if (state == HAS_QUARTER) { builder.AppendLine("Machine is waiting for crank to turn"); }
            else if (state == NO_QUARTER || state == SOLD ) { builder.AppendLine("Machine is waiting for quarter"); }

            return builder.ToString();
        }
        // other methods here like toString() and refill()

        internal object GetHasQuarterState()
        {
            throw new NotImplementedException();
        }

        internal void SetState(object p)
        {
            throw new NotImplementedException();
        }

        internal object GetNoQuarterState()
        {
            throw new NotImplementedException();
        }

        internal object GetSoldState()
        {
            throw new NotImplementedException();
        }

        internal int inventoryCount()
        {
            throw new NotImplementedException();
        }

        internal object GetSoldOutState()
        {
            throw new NotImplementedException();
        }
    }
}
