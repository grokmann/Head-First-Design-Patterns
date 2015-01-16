﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        public ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                //drain the boiled milk and chocolate
                empty = true;
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }

        public bool IsBoiled()
        {
            return boiled;
        }
    }
}
