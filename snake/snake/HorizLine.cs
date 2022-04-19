using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class HorizLine
    {
        List<Point> pL;
        public HorizLine(int xL, int xR, int y, char symb)
        {
            pL = new List<Point>();
            for(int i = xL; i <= xR; i++)
            {
                Point p = new Point(i, y, symb);
                pL.Add(p);
            }
            
        }
        public void Draw()
        {
            foreach(Point i in pL)
            {
                i.Draw();
            }
        }
    }
}
