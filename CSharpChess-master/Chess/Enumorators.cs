using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public struct Point
    {
        public int x;
        public int y;
        // <param name="x">The horazontal position</param>
        // <param name="y">The virtical position</param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

      
        // Display coordinates as a string
        //Returns coordinates in the format (x, y)
        public override string ToString()
        {
            return (String.Format("({0}, {1})", x, y));
        }
    }

    public enum Direction
    {
        FORWARD,
        BACKWARD,
        LEFT,
        RIGHT
    }

    public enum DiagnalDirection
    {
        FORWARD_LEFT,
        FORWARD_RIGHT,
        BACKWARD_LEFT,
        BACKWARD_RIGHT
    }
}
