using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains_Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int leftX, int rightX, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = leftX; x < rightX; x++)
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
