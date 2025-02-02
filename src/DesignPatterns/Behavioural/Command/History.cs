namespace DesignPatterns.src.DesignPatterns.Behavioural.Command
{
    public class History
    {
        private readonly Stack<IUndoableCommand> commands = [];

        public void Push(IUndoableCommand command)
        {
            commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            var last = commands.Pop();

            return last;
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}