namespace Ch6_Command
{
    public class TVOffCommand : ICommand
        {
            private TV tv;

            public TVOffCommand(TV tv)
            {
                this.tv = tv;
            }

            public void Execute()
            {
                tv.Off();
            }

            public void Undo()
            {
                tv.On();
            }
        }
    }
