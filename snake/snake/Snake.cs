using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pL = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                snake.Point p = new snake.Point(tail);
                p.Move(i, direction);
                pL.Add(p);
            }
        }

        internal void Move()
        {
            snake.Point tail = pL.First();
            pL.Remove(tail);
            snake.Point head = GetNextPoint();
            pL.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point nextP = pL.Last();// was head
            ///Point nextP = new Point(head);
            nextP.Move(1, direction);
            return nextP;
        }
    }
}
