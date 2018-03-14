using System.Text;

namespace Ch6_Command
{
    public class RemoteControl
    {
        ICommand[] OnCommands;
        ICommand[] OffCommands;
        int numberOfSlots = 7;

        public RemoteControl()
        {
            OnCommands = new ICommand[numberOfSlots];
            OffCommands = new ICommand[numberOfSlots];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < numberOfSlots; i++)
            {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            OnCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            OffCommands[slot].Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n----- Remote Control -----");
            for (int i = 0; i < numberOfSlots; i++)
            {
                sb.AppendFormat("[slot {0}] {1}          {2}\n", i, OnCommands[i].GetType().Name, OffCommands[i].GetType().Name);
            }
            return sb.ToString();
        }
    }
}
