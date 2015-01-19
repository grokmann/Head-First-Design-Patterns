namespace Ch6_Command
{
    public class HottubOffCommand : ICommand
    {
        private Hottub hottub;

        public HottubOffCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            hottub.Off();
        }

        public void Undo()
        {
            hottub.On();
        }
    }
}