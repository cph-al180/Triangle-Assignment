using System;

namespace Test_TriangleExercise
{
    class TriangleController
    {

        /// <summary>
        /// Checks if the parameter is less than 1, and returns true or false based on that.
        /// </summary>
        /// <param name="output"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Checks if the parameter is an integer, and returns true or false based on that.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Reads 3 inputs from Console, and creates a Triangle Object based on those. Uses GetTriangleType() to determine TriangleType of Triangle object.
        /// </summary>
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
            Console.WriteLine("Triangle is: " + triangle.GetTriangleType());
        }
    }
}