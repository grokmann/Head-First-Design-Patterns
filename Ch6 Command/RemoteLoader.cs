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

            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(3, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(4, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
                remoteControl.OnButtonWasPushed(i);
                Console.WriteLine(remoteControl);
                remoteControl.UndoButtonWasPushed();
                remoteControl.OffButtonWasPushed(i);
                remoteControl.OnButtonWasPushed(i);
            }

            Console.ReadKey();
        }
    }
}
