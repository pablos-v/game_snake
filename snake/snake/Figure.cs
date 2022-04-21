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
        internal bool IsHit(Figure fig)
        {
            foreach (var p in pL)
            {
                if (fig.IsHit(p)) return true;
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (var p in pL)
            {
                if (p.IsHit(point)) return true;
            }
            return false;
        }
    }
}
