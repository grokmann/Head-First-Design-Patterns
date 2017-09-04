using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10_State.States
{
    public class BaseState
    {
        protected GumballMachine gumballMachine;

        public BaseState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
    }
}
