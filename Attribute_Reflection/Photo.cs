using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Reflection
{
    //[Geo(10, 20)]
    class Photo
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Photo(string name) 
        {
            //Check input parameters

            Name = name;

        }
    }
}
