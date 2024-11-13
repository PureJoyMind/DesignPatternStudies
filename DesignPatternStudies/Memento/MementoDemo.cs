namespace DesignPatternStudies.Memento;

public class MementoDemo : IDemo
{
    public void Play()
    {
        var originator = new Originator();
        var caretaker = new Caretaker();
        
        originator.Content = "Hello World!";
        caretaker.Push(originator.CreateMemento());
        Console.WriteLine(originator.Content);
        
        originator.Content = "Goodbye World!";
        caretaker.Push(originator.CreateMemento());
        Console.WriteLine(originator.Content);
        
        originator.Content = "Hello again!";
        Console.WriteLine(originator.Content);
        
        originator.Restore(caretaker.Pop());
        Console.WriteLine("undo: " + originator.Content);
        
        originator.Restore(caretaker.Pop());
        Console.WriteLine("undo: " + originator.Content);
    }
}