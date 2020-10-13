using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains_Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int upY, int downY, char sym)
        {
            pList = new List<Point>();
            for (int y = upY; y < downY; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (var item in pList)
            {
                item.Draw();
            }
        }
    }
}
