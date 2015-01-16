using System;

namespace Ch6_Command
{
    public class RemoteControlTest
    {
        public static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
