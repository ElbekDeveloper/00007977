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
        public void MouseDown()
        {
            Console.WriteLine("Pen icon...");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw line upon the trajectory...");
        }
    }
}
