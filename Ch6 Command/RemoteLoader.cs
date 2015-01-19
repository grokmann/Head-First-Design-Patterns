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
            TV tv = new TV("Living Room");
            Hottub hottub = new Hottub();

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

            TVOnCommand tvOn = new TVOnCommand(tv);
            TVOffCommand tvOff = new TVOffCommand(tv);

            HottubOnCommand hottubOn = new HottubOnCommand(hottub);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { livingRoomLightOn, stereoOnWithCd, tvOn, hottubOn };
            ICommand[] partyOff = { livingRoomLightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            int slot = 0;

            remoteControl.SetCommand(slot++, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(slot++, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(slot++, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(slot++, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(slot++, stereoOnWithCd, stereoOff);
            remoteControl.SetCommand(slot++, partyOnMacro, partyOffMacro);

            Console.WriteLine(remoteControl);

            for (int i = 0; i < slot; i++)
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
