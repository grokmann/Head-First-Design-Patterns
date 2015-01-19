using System;

namespace Ch6_Command
{
    class CeilingFanOnCommand : ICommand
    {
        CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            ceilingFan.On();
        }

        public void Undo()
        {
            ceilingFan.Off();
        }
    }
}
