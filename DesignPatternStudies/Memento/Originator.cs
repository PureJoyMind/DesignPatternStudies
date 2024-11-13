namespace DesignPatternStudies.Memento;

public class Originator
{
    Stack<string> _undoStack = new Stack<string>();

    public string Content { get; set; }

    public Memento CreateMemento() => new(Content);
    
    public void Restore(Memento memento) => Content = memento.Content;
}