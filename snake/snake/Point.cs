using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Point
    {
        public int x = 1;
        public int y = 1;
        public char symb = '*';

        public Point() //Конструктор 1
        {
        }
        public Point(int _x, int _y, char _symb) //Конструктор 2
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public Point(Point p) //Конструктор 3
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.LEFT)
            {
                x -= offset;
            }
            else if (direction == Direction.RIGHT)
            {
                x += offset;
            }
            else if (direction == Direction.UP)
            {
                y -= offset;
            }
            else if (direction == Direction.DOWN)
            {
                y += offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }


    }
}
