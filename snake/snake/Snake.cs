using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            pL = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                snake.Point p = new snake.Point(tail);
                p.Move(i, direction);
                pL.Add(p);
            }
        }
    }
}
