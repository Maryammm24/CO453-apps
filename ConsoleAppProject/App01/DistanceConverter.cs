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

        ///private double feet;

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
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);

        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {

        }
     
    }
}
