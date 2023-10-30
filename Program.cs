using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this line prints the name of the program
            Console.WriteLine("Anonymous Income Comparison Program");
            // this lines prints the name and hourly rate
            Console.WriteLine("Alan Howarth");
            Console.WriteLine("Hourly Rate?");
            int rate1 = 14;
            Console.WriteLine(rate1);
            // this line displays how many hours has been worked during a week
            Console.WriteLine("Hours worked per week?");
            int hours1 = 40;
            Console.WriteLine(hours1);
            // this line displays the annual salary of Alan Howarth
            int salary1 = Convert.ToInt32(rate1) * Convert.ToInt32(hours1) * 52;
            // this lines prints the name and hourly rate
            Console.WriteLine("Ali Shaik Minhal");
            Console.WriteLine("Hourly Rate?");
            int rate2 = 16;
            Console.WriteLine(rate2);
            // this line prints how many hours has been worked during a week
            Console.WriteLine("Hours worked per week?");
            int hours2 = 40;
            Console.WriteLine(hours2);
            // this line displays the annual salary of Ali Shaik Minhal
            int salary2 = Convert.ToInt32(rate2) * Convert.ToInt32(hours2) * 52;
            Console.WriteLine("Annual Salary of Alan Howarth:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual Salary of Ali Shaik Minhal:");
            Console.WriteLine(salary2);
            // this line compares the salaries of who earns more early between the two workers
            Console.WriteLine("Does Alan Howarth make more money than Ali Shaik Minhal?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);
            // this line keeps the Command Line open so it can be read
            Console.ReadLine();
        }
    }
}
