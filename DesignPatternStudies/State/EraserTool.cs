namespace DesignPatternStudies.State;

public class EraserTool : ITool
{
    public void MouseDown()
    {
        Console.WriteLine("Eraser Icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Erase something");
    }
    
}