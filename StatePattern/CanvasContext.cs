using StatePattern.Tools;
using System;

namespace StatePattern
{
    public class CanvasContext
    {
        private ToolState _currentTool;

        //getter and setter for private field
        public ToolState GetCurrentTool()
        {
            return _currentTool;
        }

        public void SetCurrentTool(ToolState tool)
        {
            _currentTool = tool;
        }

        //Implementation of different events
        public void MouseDown()
        {
            _currentTool.MouseDown();
        }
        public  void MouseUp()
        {
            _currentTool.MouseUp();
        }
    }
}
