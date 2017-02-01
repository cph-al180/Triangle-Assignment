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
            TriangleCreation();
        }

        static void TriangleCreation()
        {
            Console.WriteLine("Yay New Triangle! :D");
            TriangleModel Triangle = new TriangleModel();

            Console.WriteLine("Side 1");
            string a = Console.ReadLine();
            Triangle.side1 = int.Parse(a);

            Console.WriteLine("Side 2");
            string b = Console.ReadLine();
            Triangle.side2 = int.Parse(b);

            Console.WriteLine("Side 3");
            string c = Console.ReadLine();
            Triangle.side3 = int.Parse(c);

            Triangle.SetTriangleType();

            Console.WriteLine(Triangle.GetTriangleType());
        }

        static void TriangleCreationSequence()
        {
            TriangleModel Triangle1 = new TriangleModel(5, 5, 5);
            TriangleModel Triangle2 = new TriangleModel(5, 5, 2);
            TriangleModel Triangle3 = new TriangleModel(5, 3, 1);

            Triangle1.SetTriangleType();
            Triangle2.SetTriangleType();
            Triangle3.SetTriangleType();

            Console.WriteLine(Triangle1.GetTriangleType());
            Console.WriteLine(Triangle2.GetTriangleType());
            Console.WriteLine(Triangle3.GetTriangleType());
        }
    }
}
