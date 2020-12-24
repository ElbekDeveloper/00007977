using StatePattern.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consider the lecturer enable the feature
            //Lay out the canvas to the screen
            CanvasContext canvas = new CanvasContext();
            //Picked up the tool 
            canvas.SetCurrentTool(new PenTool());
            canvas.MouseDown();
            canvas.MouseUp();

            Console.ReadKey();
        }
    }
}
