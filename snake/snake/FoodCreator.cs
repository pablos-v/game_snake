using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class FoodCreator
    {
        int width;
        int height;
        char symb;

        Random random = new Random();

        public FoodCreator(int width, int height, char symb)
        {
            this.width = width;
            this.height = height;
            this.symb = symb;
        }
        public Point CreateApple()
        {
            int x = random.Next(2, width-2);
            int y = random.Next(2, height-2);
            return new Point(x, y, symb);
        }
    }
}
