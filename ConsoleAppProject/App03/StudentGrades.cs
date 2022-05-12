using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        //constants
        public const int LowestMark = 0;
        public const int HighestMark = 100;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;   
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;

        //properties
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public string StudentClass { get; set; }

        public StudentGrades()
        {
            Students = new string[]
            {
                "Maryam", "Sham", "Leighton", "Ali", "Amir",
                "Esha", "Shafaq", "Iman", "Boris", "Bilal"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        public void StudentMenu()
        {
            ConsoleHelper.OutputHeading("Student Marks Application");
            DisplayMenu("Please enter your choice > ");
        }

        private void DisplayMenu(string prompt)
        {
            string[] choices =
            {
                "Input Marks",
                "Output Marks",
                "Output Stats",
                "Output Grade Profile",
                "Edit Name Student",
                "Quit"
            };
            int choiceNo = ConsoleHelper.SelectChoice(choices);
            ExecuteMenu(choiceNo);
        }

        private void ExecuteMenu(int choiceNo)
        {
            switch (choiceNo)
            {
                case 1:
                    InputMarks();
                    break;
                case 2:
                    OutputMarks();
                    break;
                case 3:
                    CalculateStats();
                    OutputStats();
                    break;
                case 4:
                    CalculateGradeProfile();
                    OutputGradeProfile();
                    break;
                case 5:
                    EditName();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    DisplayMenu("Please enter your choice > ");
                    break;

            }
        }

            public void InputMarks()
            {
                Console.WriteLine("\nPlease enter a mark for each student.\n");

                for (int i = 0; i < Students.Length; i++)
                {
                Marks[i] = (int)ConsoleHelper.InputNumber($"Enter {Students[i]} marks: ", LowestMark, HighestMark);
                }

            Console.WriteLine();
            DisplayMenu("\nPlease enter your choice > ");

            }

        public void OutputMarks()
        {
            Console.WriteLine("\nOuput mark for each student. \n");

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Students Name: {Students[i]} \nStudent Mark: {Marks[i]}\n + " +
                    $"Student Grade: {ConvertToGrade(Marks[i])}\nStudent Class: {StudentClass}\n");
            }

            DisplayMenu("\n\nPlease enter your choice > ");
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                StudentClass = "Fail";
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                StudentClass = "Third Class";
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                StudentClass = "Lower Second";
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                StudentClass = "Upper Second";
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                StudentClass = "First Class";
                return Grades.A;
            }
            else
            {
                return Grades.F;
            }
        }

        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[1];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum)
                {
                    Maximum = mark;
                }
                else if (mark < Minimum)
                {
                    Minimum = mark;
                }
                total += mark;
            }

            Mean = total / Marks.Length;
        }

        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
        }

        public void OutputGradeProfile()
        {
            Grades grade = Grades.D;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();
            DisplayMenu("\n\nPlease enter your choice > ");
        }

        public void OutputStats()
        {
            Console.WriteLine("\nOuput the Statistics of marks\n");
            Console.WriteLine($"Mean Mark: {Mean}\nMinimum Mark: {Minimum}\nMaximum Mark: {Maximum}");
            Console.WriteLine();
            DisplayMenu("\n\nPlease enter your choice > ");
        }

        public void EditName()
        {
            Console.WriteLine("Enter the name of the student you want to edit: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the new student name: ");
            string NewName = Console.ReadLine();
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Equals(name))
                {
                    Students[i] = NewName;
                }
            }
            Console.WriteLine();
            DisplayMenu("\nPlease enter your choice > ");
        }

    }
}
