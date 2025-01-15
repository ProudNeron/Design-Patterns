namespace DesignPatterns.src.DesignPatterns.Behavioural.Memento.GoodExample
{
    public class History
    {
        private readonly List<EditorState> _states = [];
        private readonly Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void BackUp()
        {
            _states.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if (_states.Count == 0)
            {
                return;
            }

            EditorState prevState = _states.Last();
            _states.Remove(prevState);

            _editor.Restore(prevState);
        }

        public void ShowHistory()
        {
            System.Console.WriteLine("The list of mementos:");

            foreach (var state in _states)
            {
                state.GetName();
            }
        }
    }
}