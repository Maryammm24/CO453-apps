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
        public double FromDistance { get; set; }
        public double ToDistance { get; set; }
        public double value;

        //fromUnit and toUnit 
        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }
        
        public DistanceConverter2()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

        public void ConvertDistance()
        {
            OutputHeading();

            FromUnit = SelectUnit(" Select the from distance unit > ");
            ToUnit = SelectUnit(" Select the to distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Enter the number of {FromUnit} >");

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

        public void CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
        }


        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance} {FromUnit} " + $" is {ToDistance} {ToUnit}!\n");
        }
    }
}
