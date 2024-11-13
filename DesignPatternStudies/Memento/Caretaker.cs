using System.Diagnostics.CodeAnalysis;

namespace DesignPatternStudies.Memento;

public class Caretaker
{
    Stack<Memento> States { get; set; } = new Stack<Memento>();
    
    public Memento Pop() => States.Pop();
    public void Push(Memento memento) => States.Push(memento);
}