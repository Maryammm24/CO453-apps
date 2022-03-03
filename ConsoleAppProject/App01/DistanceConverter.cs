using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Maryam Hanif version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;

        private const int MilesToFeet = 5280;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        /// <summary>
        /// Ask the user to input the distance in miles,
        /// Input the miles as a double number.
        /// </summary>
        private void InputMiles()
        {
            Console.WriteLine();
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }

        private void InputFeet()
        {
            Console.WriteLine();
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * MilesToFeet;
        }

        private void CalculateMiles()
        {
            miles = feet / MilesToFeet;
        }

        /// <summary>
        /// 
        /// </summary>
        ///
        private void OutputFeet()
        {
            OutputHeading();
            Console.WriteLine();
            Console.WriteLine(miles + " miles is " + feet + " feet!");
        }
        private void OutputMetres()
        {
            Console.WriteLine();
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }
        private void OutputMiles()
        {
            Console.WriteLine();
            Console.WriteLine(feet + " feet is " + miles + " miles!");
        }
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("       Convert Miles to Feet       ");
            Console.WriteLine("          by Maryam Hanif          ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
        }
     
    }
}
