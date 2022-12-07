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
        // x horizontal position
        // y the vertical position
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
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
