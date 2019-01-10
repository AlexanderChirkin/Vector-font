using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    /// <summary>
    /// Линии между точками, используется 2 или 4 точки, в зависимости от типа линии
    /// </summary>
    [Serializable]
    public class Link
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; } 
        public Point P4 { get; set; }
        public Links LinksType { get; set; }
    }
}
