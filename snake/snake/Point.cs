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

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

    }
}
