using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Point : IComparable<Point>, IComparer<Point>
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Compare(Point p2, Point p3)
        {
            double slopeP2 = this.SlopeTo(p2);
            double slopeP3 = this.SlopeTo(p3);
            return 
        }

        public int CompareTo(Point p2)
        {
            if (this.y != p2.y)
                return this.y.CompareTo(p2.y);
            else
                return this.x.CompareTo(p2.x);
        }

        public double SlopeTo(Point p2)
        {
            if ((p2.x == this.x) && (p2.y == this.y))
            {
                return double.NegativeInfinity;
            }
            else if ((p2.x - this.x) == 0)
            {
                return double.PositiveInfinity;
            }
            else if ((p2.y - this.y) == 0)
            {
                return 0;
            }
            else return (p2.y - this.y) / (p2.x - this.x);

        }
    }
}
