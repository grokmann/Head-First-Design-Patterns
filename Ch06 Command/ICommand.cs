namespace Ch6_Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
