using System;

namespace Ch6_Command
{
    public class RemoteLoader
    {
        public static void Main(string[] args)
        {
            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("");
            Stereo stereo = new Stereo("Living Room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl);

            for (int i = 0; i < 4; i++)
            {
                remoteControl.OnButtonWasPushed(i);
                remoteControl.OffButtonWasPushed(i);
                Console.WriteLine(remoteControl);
                remoteControl.UndoButtonWasPushed();
                remoteControl.OffButtonWasPushed(i);
                remoteControl.OnButtonWasPushed(i);
                Console.WriteLine(remoteControl);
                remoteControl.UndoButtonWasPushed();
            }

            Console.ReadKey();
        }
    }
}
