using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10_State
{
    public class GumballMachine
    {
        const int SOLD_OUT = 0;
        const int NO_QUARTER = 1;
        const int HAS_QUARTER = 2;
        const int SOLD = 3;

        int state = SOLD_OUT;
        int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
            {
                state = NO_QUARTER;
            }
        }

        public void insertQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("You can't insert another quarter");
            }
            else if (state == NO_QUARTER)
            {
                state = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can't insert a quarter, the machine is sold out");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Please wait, we're already giving you a gumball");
            }
        }

        public void ejectQuarter()
        {
            if (state == HAS_QUARTER)
            {
                Console.WriteLine("Quarter returned");
                state = NO_QUARTER;
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You haven't inserted a quarter");
            }
            else if (state == SOLD)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
            }
        }

        public void turnCrank()
        {
            if (state == SOLD)
            {
                Console.WriteLine("Turning twice doesn't get you another gumball!");
            }
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You turned but there's no quarter");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("You turned, but there are no gumballs");
            }
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("You turned...");
                state = SOLD;
                dispense();
            }
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
            else if (state == NO_QUARTER)
            {
                Console.WriteLine("You need to pay first");
            }
            else if (state == SOLD_OUT)
            {
                Console.WriteLine("No gumball dispensed");
            }
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("No gumball dispensed");
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
    }
}
