namespace DesignPatterns.src.DesignPatterns.Behavioural.Command
{
    // This is where we implement our business logic. This class knows nothing about commands.
    // This is part of the "business layer" of an application.
    // Commands are the link between user interface object, and business objects.
    public class HtmlDocument
    {
        public string Content { get; set; } = null!;

        public void MakeItalic()
        {
            Content = "<i>" + Content + "</i>";
        }
    }
}