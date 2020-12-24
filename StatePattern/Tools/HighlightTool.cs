using System;


namespace StatePattern.Tools
{
    public class HighlightTool : ToolState
    {
        public HighlightTool()
        {
            Console.WriteLine("Highlight tool is selcted...");
        }
        public void MouseDown()
        {
            Console.WriteLine("Start highlighting.\nHighlighting upon trajectory...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Stop highlighting...");
        }
    }
}
