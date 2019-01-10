using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LogicLibrary
{
    /// <summary>
    /// Представляет собой список точек и список связей между ними
    /// </summary>
    [Serializable]
    public class Symbol:IDrawableObject
    {
        public List<Point> Points { get; set; }
        public List<Link> Links { get; set; }

        public Symbol()
        {
            Points= new List<Point>();
            Links = new List<Link>();
        }
    }
}
