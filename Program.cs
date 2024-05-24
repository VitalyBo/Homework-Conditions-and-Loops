using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Сonsole
{
    class Program
    {

        static void Main(string[] args)
        {
                        
            Console.OutputEncoding = Encoding.Unicode;
            bool condition = true;
            Console.WriteLine("\nVitalii Bobyr - 05/13/24");
            Console.WriteLine("Programming 120 - Code Practice - Booleans and Conditions");
        #region start_of_prog
        start:
            while (condition)
            {
                Console.WriteLine("\r\n1.Check the temperature\n2.Check Odd or Even\n3.Leap Year Checker\ne.Exit");
                Console.WriteLine("Choose what you want and put some number from 1 to 4");
                string choice;
                choice = Console.ReadLine().ToLower();

                try
                {
                    switch (choice)
                    {
                        #region task_1
                        case "1":
                            Console.WriteLine("Check the temperature");
                            Console.Write("Put some number: ");
                            int number = int.Parse(Console.ReadLine());
                            Weather weather = new Weather();
                            weather.display_temperature(number);
                            goto start;
                        #endregion
                        #region task_2
                        case "2":
                            Console.WriteLine("Check Odd or Even");
                            odd_or_even odd_Or_Even = new odd_or_even();
                            Console.Write("Put some number: ");
                            int numb = int.Parse(Console.ReadLine());
                            try
                            {
                                odd_Or_Even.display_odd_or_even(numb);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input. Please enter a valid integer.");
                                goto start;
                            }
                            goto start;
                        #endregion
                        #region task_3
                        case "3":
                            Console.WriteLine("Leap Year Checker");
                            Console.Write("Put some year: ");
                            int year = int.Parse(Console.ReadLine());
                            if (IsLeapYear(year))
                            {
                                Console.WriteLine($"{year} is a leap year.");
                            }
                            else
                            {
                                Console.WriteLine($"{year} is not a leap year.");
                            }
                            goto start;
                        #endregion

                        case "e":
                            Console.WriteLine("Exit from progarm");
                            condition = false;
                            break;

                    }

                }
                catch
                {
                    Console.WriteLine("Something going wrong! Please try again!");
                    goto start;
                }

            }
            #endregion end_of_prog

        }


        #region classes_and_methods
        public class Weather
        { 
                   public void display_temperature(int temperature)
                   {
                     if (temperature <= 32) {Console.WriteLine ("That's freezing, be careful out there."); }
                     if (temperature >= 33 &&  temperature <= 50) { Console.WriteLine("It's really cold out, bring a jacket."); }
                     if (temperature >= 51 && temperature <= 68) { Console.WriteLine("It's starting to get cold. A sweater should work"); }
                     if (temperature >= 69 && temperature <= 75) { Console.WriteLine("It's comfortable out. A shirt and jeans will work"); }
                     if (temperature >= 76) { Console.WriteLine("It's T-shirt and shorts time"); }
                   }
        }

        public class odd_or_even
        {
            public void display_odd_or_even (int number)
            {                   
                    if (number % 2 == 0) { Console.WriteLine("The number is even."); }
                    else { Console.WriteLine("The number is odd."); }
            }
        }

        static bool IsLeapYear(int year)
        {
             if (year % 400 == 0) { return true; }
             if (year % 100 == 0) { return false; }
             if (year % 4 == 0) { return true; }
             return false;
        }
    }

    #endregion
}

