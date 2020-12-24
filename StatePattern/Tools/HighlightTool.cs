using System;


namespace StatePattern.Tools
{
    public class HighlightTool : ToolState
    {
        public void MouseDown()
        {
            Console.WriteLine("Highlight icon...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Highlight upon trajectory...");
        }
    }
}
