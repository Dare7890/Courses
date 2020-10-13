using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains_Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int upY, int downY, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = upY; y < downY; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
