using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Walls
    {
        List<Figure> wallList;

        public Walls(int width, int height)
        {
            wallList = new List<Figure>();

            HorizLine lineUp = new HorizLine(0, width, 0, '-');
            HorizLine lineDown = new HorizLine(0, width, height, '-');
            VertLine lineLeft = new VertLine(0, 0, height, '|');
            VertLine lineRight = new VertLine(width, 0, height, '|');
            wallList.Add(lineDown);
            wallList.Add(lineUp);
            wallList.Add(lineLeft);
            wallList.Add(lineRight);
        }
        public void Draw()
        {
           foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure fig)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(fig)) return true;
            }
            return false;
        }
    }
}
