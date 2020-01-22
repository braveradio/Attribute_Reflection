using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }




            Console.ReadLine(); 
        }
    }
}
