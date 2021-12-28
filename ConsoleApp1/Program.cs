using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the school");
            string schoolNmae = Console.ReadLine();

            Console.WriteLine("Enter the course name");
            string courseName = Console.ReadLine();

            Console.WriteLine("Enter the studen count");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Today;
            DateTime courseStartDate = today.AddDays(-7);
            DateTime courseEntDate = courseStartDate.AddMonths(8);


            Console.WriteLine($"School's name: {schoolNmae}");
            Console.WriteLine($"Course's name: {courseName}");
            Console.WriteLine($"Amount of students: {studentCount}");
            Console.WriteLine($"Todays date: {today}");
            Console.WriteLine((courseEntDate - courseStartDate).Days);
            Console.ReadLine();


            Console.WriteLine("Task 1");
            int x = 5;
            int y = 3;
            int b = x;
            x = y;
            y = b;
            Console.WriteLine($" x is {x}, y is {y}");
            Console.ReadLine();

            Console.WriteLine("Task 2");
            Console.WriteLine("Enter a number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number b");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a == B);
            Console.ReadLine();

            Console.WriteLine("Task 3");
            Console.WriteLine("Enter a number c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number d");
            int d = Convert.ToInt32(Console.ReadLine());
            c++;
            d--;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();

            Console.WriteLine("Task 4");
            Console.WriteLine("Enter rectangle height");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rectangle length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Regtagle perimeter is: {2 * (length + height)}");
            Console.WriteLine($"Regtagle area is: {length * height}");
            Console.ReadLine();

            Console.WriteLine("Task 5");
            Console.WriteLine("Enter something");
            string f = Console.ReadLine();
            Console.WriteLine(String.IsNullOrEmpty(f));
            Console.ReadKey();

            Console.WriteLine("Task 6");
            Console.WriteLine("Enter number e");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(e < 0);
            Console.ReadLine();

            Console.WriteLine("Task 7");
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine($"NAme is: {name}, last name is: {lastname}");
            Console.ReadLine();

            Console.WriteLine("Enter a text with upper case");
            string upperCase = Console.ReadLine();
            Console.WriteLine(upperCase.ToLower());
            Console.ReadLine();

            Console.WriteLine("Task 5");
            Console.WriteLine("Enter something");
            string g = Console.ReadLine();
            string isEmpty = string.IsNullOrEmpty(f) ? "Is empty" : "is not empty";
            Console.WriteLine(isEmpty);
            Console.ReadKey();

            string word = "Vilnius";
            string text = "Vilnius is a capital city";
            string firstWord = text.Split(' ')[0];
            bool isStartsWithVilnius = word == firstWord ? true : false;
            Console.WriteLine(isStartsWithVilnius);
            Console.ReadLine();


           
            string text1 = "Vilnius is a capital city";
            Console.WriteLine(text1.Length);
            Console.ReadLine();

            string text2 = "Vilnius is a capital city";
            string[] wordList = text2.Split(' ');
            Console.WriteLine(wordList.Length);
            Console.ReadLine();
        }

    }
}
