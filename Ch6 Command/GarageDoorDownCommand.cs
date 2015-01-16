using System;

namespace Ch6_Command
{
    class GarageDoorDownCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
        }
    }
}
