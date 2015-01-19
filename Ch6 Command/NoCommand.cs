using System;

namespace Ch6_Command
{
    internal class NoCommand : ICommand
    {
        public void Execute() { }

        public void Undo() { }
    }
}