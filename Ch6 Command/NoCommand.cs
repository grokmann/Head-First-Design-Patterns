﻿using System;

namespace Ch6_Command
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}