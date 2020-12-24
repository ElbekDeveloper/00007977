using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Tools
{
    /// <summary>
    /// Individual tool
    /// </summary>
    public class PenTool : ToolState
    {
        public PenTool()
        {
            Console.WriteLine("Pen tool was selected.\nIcon changes");
        }
        public void MouseDown()
        {
            Console.WriteLine("Pen starts drawing...\nDrawing line upon trajectory...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Stop drawing...");
        }
    }
}
