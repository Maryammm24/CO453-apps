using System;
namespace ConsoleAppProject.App01
{
    public class DistanceConverter2
    {
        //Distance conversion constants 
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        //From/to distance variables
        private double fromDistance;
        private double toDistance;
        public double value;

        //fromUnit and toUnit 
        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;
        
        public DistanceConverter2()
        {
            fromUnit = DistanceUnits.Miles;
            toUnit = DistanceUnits.Feet;
        }

        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Select the from distance unit > ");
            toUnit = SelectUnit(" Select the to distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Enter the number of {fromUnit} >");

            CalculateDistance();

            OutputDistance();
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("         Distance Converter         ");
            Console.WriteLine("          by Maryam Hanif          ");
            Console.WriteLine("-----------------------------------\n");
        }

        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            DistanceUnits unit = ExecuteChoice(choice);

            return unit;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {DistanceUnits.Feet}");
            Console.WriteLine($" 2. {DistanceUnits.Metres}");
            Console.WriteLine($" 3. {DistanceUnits.Miles}");

            Console.Write(prompt);
            string choice = Console.ReadLine();

            return choice;
        }

        private DistanceUnits ExecuteChoice(string choice)
        {
            DistanceUnits unit;

            switch (choice)
            {
                case "1": unit = DistanceUnits.Feet;
                    break;
                case "2": unit = DistanceUnits.Metres;
                    break;
                case "3": unit = DistanceUnits.Miles;
                    break;

                default: unit = DistanceUnits.NoUnit;
                    break;
            }

            if (unit == DistanceUnits.NoUnit)
            {
                Console.WriteLine("Invalid Choice!");
                Console.WriteLine();
                Console.WriteLine("Must be a digit 1 to 3");
            }

            Console.WriteLine($"\nYou have chosen {unit}");
            return unit;
        }

        private double InputDistance(string prompt)
        {
            Boolean finish = false;
            
            do
            {
                try
                {
                    Console.Write(prompt);
                    value = double.Parse(Console.ReadLine());
                    if (value <= 0)
                    {
                        Console.WriteLine("Value must be more than 0.0");
                        finish = false;
                    }
                    else
                    {
                        finish = true;
                    }
                }
                catch
                {
                    Console.Write("Error");
                }
            }
            while (finish == false);

            return value;
        }

        private void CalculateDistance()
        {
            if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }


        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit} " + $" is {toDistance} {toUnit}!\n");
        }
    }
}
