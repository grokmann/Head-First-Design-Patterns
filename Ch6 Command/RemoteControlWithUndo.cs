using System.Text;

namespace Ch6_Command
{
    public class RemoteControlWithUndo
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;
        int numberOfSlots = 7;

        public RemoteControlWithUndo()
        {
            onCommands = new ICommand[numberOfSlots];
            offCommands = new ICommand[numberOfSlots];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < numberOfSlots; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n----- Remote Control -----");
            for (int i = 0; i < numberOfSlots; i++)
            {
                sb.AppendFormat("[slot {0}]\t{1, -25} {2, -20}\n", i, onCommands[i].GetType().Name, offCommands[i].GetType().Name);
            }
            sb.AppendFormat("[undo]\t\t{0, -25}", undoCommand.GetType().Name);
            return sb.ToString();
        }
    }
}
