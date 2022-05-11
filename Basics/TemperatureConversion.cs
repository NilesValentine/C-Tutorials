using System;

namespace CSharpTutorials.Tutorials.Basics

/* Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees. For the sake of this project, temperature below -271.15°C (absolute zero) does not exist!  */


{
    class CtoFTask
    {
        public static string CtoF(double celsius)
        {
            double fahrenheit;

            if (celsius < -273.15)
            {
                return "Temperature below absolute zero!";
            }

            fahrenheit = celsius * 1.8 + 32;
           
            return $"T = {fahrenheit}F";
        }

        public static void Main()
        {
            Console.WriteLine(CtoF(0));     // T = 32F
            Console.WriteLine(CtoF(-300));  // Temperature below absolute zero!
            Console.WriteLine(CtoF(28.5));  // T = 83.3F
        }
    }
}