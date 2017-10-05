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
        IState winnerState;

        IState outOfGumballsState;

        IState state;

        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            outOfGumballsState = new OutOfGumballsState(this);

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

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Mighty Gumball, Inc.");
            builder.AppendLine("C-Sharp-enabled Standing Gumball Model #2015");
            builder.AppendFormat("Inventory: {0} gumball", count);

            if (count != 1)
            {
                builder.Append("s");
            }

            builder.AppendLine();
            builder.AppendFormat("Machine is {0}", state);

            return builder.ToString();
        }

        internal void SetState(IState state)
        {
            this.state = state;
        }

        internal void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot…");
            if (count != 0)
            {
                count -= 1;
            }
        }

        internal int GetCount()
        {
            return count;
        }

        internal void Refill(int numberOfGumballs)
        {
            count = numberOfGumballs;
            Console.WriteLine("Refilling: {0} gumballs added!", numberOfGumballs);
        }

        public IState GetHasQuarterState()
        {
            return this.hasQuarterState;
        }

        public IState GetNoQuarterState()
        {
            return this.noQuarterState;
        }

        public IState GetSoldState()
        {
            return this.soldState;
        }

        public IState GetSoldOutState()
        {
            return this.soldOutState;
        }

        public IState GetWinnerState()
        {
            return this.winnerState;
        }

        public IState GetOutOfGumballsState()
        {
            return this.outOfGumballsState;
        }
    }
}
