using System;

namespace Ch10_State.States
{
    class OutOfGumballsState : IState
    {
        private GumballMachine gumballMachine;

        public OutOfGumballsState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Oops, out of gumballs!");
            gumballMachine.Refill(5);
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }
    }
}