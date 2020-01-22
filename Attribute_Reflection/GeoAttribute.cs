using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Reflection
{
    class GeoAttribute : Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public GeoAttribute() { }

        public GeoAttribute(int x, int y)
        {
            // Check input parameters

            X = x;
            Y = y; 
        }

        public override string ToString()
        {
            return $"[{X};  {Y}]";
        }
    }
}
