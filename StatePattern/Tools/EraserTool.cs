
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
        public void MouseDown()
        {
            Console.WriteLine("Eraser icon...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase upon the trajectory...");
        }
    }
}
