namespace Ch6_Command
{
    internal class HottubOnCommand : ICommand
    {
        private Hottub hottub;

        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            hottub.On();
        }

        public void Undo()
        {
            hottub.Off();
        }
    }
}