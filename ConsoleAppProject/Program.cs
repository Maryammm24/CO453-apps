using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Maryam Hanif 14/12/2020
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("BNU CO453 Applications Programming");
            Console.WriteLine("Maryam Hanif");
            Console.WriteLine();
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Select the Program you would like to run:");
            Console.WriteLine();
            Console.WriteLine("1. App01: Distance Converter");
            Console.WriteLine("2. App02: BMI Calculator");
            Console.WriteLine("3. App03: Student Marks");
            Console.WriteLine("4. App04: Social Network");
            Console.WriteLine("5. App05: RPS Game");
            Console.WriteLine();
            Console.WriteLine("Enter the Program Number: ");
            Console.WriteLine();
            string Choice = Console.ReadLine();

            switch (Choice)
            {
                case "1":
                    Console.WriteLine("You have selected Distance converter");
                    DistanceConverter2 converter = new DistanceConverter2();
                    converter.ConvertDistance();
                    break;
                case "2":
                    Console.WriteLine("You have selected Distance converter");
                    BMI calculator = new BMI();
                    calculator.ConvertBmi();
                    break;
                case "3":
                    Console.WriteLine("You have selected Distance converter");
                    StudentGrades grades = new StudentGrades();
                    grades.StudentMenu();
                    break;
                case "4":
                    Console.WriteLine("You have selected Distance converter");
                    NewsFeed feed  = new NewsFeed();
                    //feed.DisplayMenu();
                    break;
                
            }
        }

    }
}
