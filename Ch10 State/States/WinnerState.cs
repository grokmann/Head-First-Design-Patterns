using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State.States
{
    class WinnerState : BaseState, IState
    {
        public WinnerState(GumballMachine gumballMachine)
            : base(gumballMachine)
        {

        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
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
