using System;

namespace Ch6_Command
{
    public class SimpleRemoteControlTest
    {
        public void Test(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light("kitchen");
            GarageDoor garageDoor = new GarageDoor("");
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorUpCommand garageOpen = new GarageDoorUpCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
