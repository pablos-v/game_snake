using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class VertLine : Figure
    {
        public VertLine(int x, int yT, int yB, char symb)
        {
            pL = new List<Point>();
            for (int i = yT; i <= yB; i++)
            {
                Point p = new Point(x, i, symb);
                pL.Add(p);
            }

        }
    }
}
