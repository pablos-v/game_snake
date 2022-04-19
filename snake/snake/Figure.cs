using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Figure
    {
        protected List<Point> pL;
        public void Draw()
        {
            foreach (Point i in pL)
            {
                i.Draw();
            }
        }
    }
}
