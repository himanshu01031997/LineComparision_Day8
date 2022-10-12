using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{


    public class Comparision
    {
        int x1, y1, x2, y2;

        public Comparision(int x1, int y1, int x2, int y2)//constructor
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public double calculate()
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //   Console.WriteLine("length of the line is {0}",length);
            return length;

        }
    }
}