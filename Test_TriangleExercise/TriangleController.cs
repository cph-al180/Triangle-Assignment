using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_TriangleExercise
{
    class TriangleController
    {
        public void TriangleCreation()
        {
            Console.WriteLine("New Triangle!");
            int[] sides = new int[3];
            for (int i = 0; i < sides.Length; i++)
            {
                string input = Console.ReadLine();
                while(int.Parse(input) <= 0)
                {
                    Console.WriteLine("Invalid input - Must be greater than 0");
                    input = Console.ReadLine();
                }
                try
                {
                    int output = int.Parse(input);
                    if (int.TryParse(input, out output))
                    {
                        sides[i] = output;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input - Must be an integer");
                }
            }
            Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
            triangle.SetTriangleType();
            Console.WriteLine("Triangle is: " + triangle.GetTriangleType());  
        }
    }
}
