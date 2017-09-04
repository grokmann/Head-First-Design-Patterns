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
            soldOutState = new SoldOutState(this);
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

        internal void ReleaseBall()
        {
            throw new NotImplementedException();
        }

        public void ejectQuarter()
        {
            state.EjectQuarter();
        }

        internal IState getNoQuarterState()
        {
            throw new NotImplementedException();
        }

        public void turnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        internal void SetState(IState state)
        {
            this.state = state;
        }

        void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot…");
            if (count != 0)
            {
                count -= 1;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("Mighty Gumball, Inc.");
            builder.AppendLine("C-Sharp-enabled Standing Gumball Model #2015");
            builder.AppendFormat("Inventory: {0} gumball\r\n", count);

            if (count != 1)
            {
                builder.Append("s");
            }

            builder.AppendLine();
            builder.AppendFormat("Machine is {0}", state);

            return builder.ToString();
        }

        public IState GetHasQuarterState()
        {
            throw new NotImplementedException();
        }

        public IState GetNoQuarterState()
        {
            throw new NotImplementedException();
        }

        public IState GetSoldState()
        {
            throw new NotImplementedException();
        }

        internal int getCount()
        {
            throw new NotImplementedException();
        }

        public IState GetSoldOutState()
        {
            throw new NotImplementedException();
        }
    }
}
