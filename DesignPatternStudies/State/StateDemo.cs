namespace DesignPatternStudies.State;

public class StateDemo : IDemo
{
    public void Play()
    {
        var canvas = new Canvas();
        canvas.Tool = new EraserTool();
        canvas.MouseDown();
        canvas.MouseUp();
    }
}