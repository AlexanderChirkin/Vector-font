using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LogicLibrary
{
    public interface IDrawableObject
    {
        List<Point> Points { get; set; }
        List<Link> Links { get; set; }
    }
}
