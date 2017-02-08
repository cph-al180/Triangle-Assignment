using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_TriangleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleController tc = new TriangleController();
            while(true)
            {
                tc.TriangleCreation();
            }
        }
   }
}
