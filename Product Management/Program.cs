using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
   class Program
    {
        static void Main(string[] args)
        {

            Refrigerator refregirator = new Refrigerator();
            refregirator.Setrefrigeratordata(101, "y", "samsung", 80000, 1000, "Al", "doubledoor");
            refregirator.Display();

        }
    }
}
