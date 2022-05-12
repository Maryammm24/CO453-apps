using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
    public static class ConsoleHelper
    {

        public static void OutputHeading(string title)
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"\t{title}    ");
            Console.WriteLine("\tby Maryam Hanif      ");
            Console.WriteLine("------------------------------------------------------------\n");
        }

        public static void OuputTitle(string titles)
        {
            Console.WriteLine("\t---------------------------------------------");
            Console.WriteLine($"\t\t|{titles}|");
            Console.WriteLine("\t---------------------------------------------\n");
        }

        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool Isvalid;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    Isvalid = true;
                }
                catch (Exception)
                {
                    Isvalid = false;
                    Console.WriteLine("Invalid number!");
                }
            }
            while (!Isvalid);
            return number;
        }

        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid = false;
            double number = 0;

            do
            {
                number = InputNumber(prompt);
                if (number < min || number > max)
                {
                    isValid = false;
                    Console.WriteLine($"Number must be between {min} and {max}");
                }
                else isValid = true;
            }
            while (!isValid);
            return number;
        }

        public static int SelectChoice(string[] choices)
        {
            //Display all the choices
            DisplayChoices(choices);

            //Input the users choice as a number
            int choiceNo = (int)InputNumber("\nPlease enter your choice > \n", 1, choices.Length);
            return choiceNo;
        }

        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($" {choiceNo}. {choice}");
            }
        }
    }
}