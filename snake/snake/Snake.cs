﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Snake : Figure
    {
        public Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pL = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pL.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pL.First();
            pL.Remove(tail);
            Point head = GetNextPoint();
            pL.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pL.Last();
            Point nextP = new Point(head);
            nextP.Move(1, direction);
            return nextP;
        }
        public void DirectionListener(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow) direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow) direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow) direction = Direction.DOWN;
        }
        internal bool Eat(Point apple)
        {
            Point head = GetNextPoint();
            if (head.IsHit(apple))
            {
                apple.symb = head.symb;
                pL.Add(apple);
                return true;
            }
            else return false;
        }
    }
}
