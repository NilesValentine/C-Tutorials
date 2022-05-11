using System;

namespace CSharpTutorials.Tutorials.Basics

/* Given two different arithmetic operations (addition, substraction, multiplication, division), write a method that checks if they return the same result. */


{
    class IsResultTheSameTask
    {
        public static bool IsResultTheSame(double a, double b)
        {
            return a == b;
        }

        public static void Main()
        {
            Console.WriteLine(IsResultTheSame(3 * 3, 18 / 2));           // True
            Console.WriteLine(IsResultTheSame(3 + 7, 12 - 8));           // False
            Console.WriteLine(IsResultTheSame(3 * 7 * 8, 256 / 2 / 3));  // False
        }
    }
}