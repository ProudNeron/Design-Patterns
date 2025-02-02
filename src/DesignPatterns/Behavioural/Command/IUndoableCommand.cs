namespace DesignPatterns.src.DesignPatterns.Behavioural.Command
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}