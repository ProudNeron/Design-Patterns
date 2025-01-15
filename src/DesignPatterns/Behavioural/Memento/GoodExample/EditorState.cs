namespace DesignPatterns.src.DesignPatterns.Behavioural.Memento.GoodExample
{
    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;
        private readonly DateTime _createdAt;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
            _createdAt = DateTime.Now;
        }

        public string GetTitle()
        {
            return _title;
        }
        public string GetContent()
        {
            return _content;
        }
        public DateTime GetDate()
        {
            return _createdAt;
        }

        public void GetName(){
            System.Console.WriteLine($"Title: {_title}, Date: {_createdAt}");
        }
    }
}