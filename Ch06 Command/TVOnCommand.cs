namespace Ch6_Command
{
    public class TVOnCommand : ICommand
        {
            private TV tv;

            public TVOnCommand(TV tv)
            {
                this.tv = tv;
            }

            public void Execute()
            {
                tv.On();
            }

            public void Undo()
            {
                tv.Off();
            }
        }
    }
