using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_TriangleExercise
{
    class TriangleController
    {

        bool IsGreaterThanZero(int output)
        {
            if(output >= 1)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input - Must be greater than 0");
                return false;
            }
        }

        bool IsInt(string input)
        {
            try
            {
                int output = int.Parse(input);
                if (int.TryParse(input, out output))
                    return true;
                else
                    return false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input - Must be an integer");
                return false;
            }
        }

        public void TriangleCreation()
        {
            Console.WriteLine("New Triangle!");
            int[] sides = new int[3];
            for (int i = 0; i < sides.Length; i++)
            {
                bool valid = false;
                while (valid == false)
                {
                    string input = Console.ReadLine();
                    if (IsInt(input))
                    {
                        int output = int.Parse(input);
                        if (IsGreaterThanZero(output))
                        {
                            sides[i] = output;
                            valid = true;
                        }
                    }
                }
            }
            Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
            triangle.SetTriangleType();
            Console.WriteLine("Triangle is: " + triangle.GetTriangleType());
        }
    }
}