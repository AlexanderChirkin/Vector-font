using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    [Serializable]
    public class Point:ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xw, int y)
        {
            this.X = xw;
            this.Y = y;
        }

        public object Clone()
        {
            return new Point(this.X,this.Y);
        }
    }
}
