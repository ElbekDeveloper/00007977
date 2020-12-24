
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
    public class EraserTool : ToolState
    {
        public EraserTool()
        {
            Console.WriteLine("Eraser was selected...");
        }
        public void MouseDown()
        {
            Console.WriteLine("Start erasing.\nErase upon the trajectory...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Stop erasing...");
        }
    }
}
