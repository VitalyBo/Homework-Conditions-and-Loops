
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Сonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;


            while (true)
            {
                int choice = 0;

                Console.WriteLine("\nChoose what you want: \n1.Task: Write a program to take an " +
                    "integer input from the user. Determine if the number is positive, negative," +
                    " or zero.Display the result.\n2.Write a program to take three different " +
                    "numbers as input. Determine the largest of the three numbers and display it.\n3." +
                    "Write a program that takes an alphabet as input. Check whether the input is a " +
                    "vowel (a, e, i, o, u) or a consonant.\n4.Write a program to print the" +
                    "multiplication table of a given number up to 10.Ask the user for a " +
                    "number, then print out the related multiplication table.\n5.Write a program to " +
                    "determine if a given number is a prime number (a number only divisible by " +
                    "1 and itself).\n6.Write a program that prints the numbers from 1 to 100." +
                    "However:\n\nFor multiples of three, print \"Fizz\" instead of the number." +
                    "\r\nFor multiples of five, print \"Buzz\".\r\nFor numbers that are multiples " +
                    "of both three and five, print \"FizzBuzz\".\n7.Exit from program");
                Console.WriteLine("\nChoose and put number from 1 to 7");

                choice = int.Parse(Console.ReadLine());



                if (choice == 1)
                {

                    Console.WriteLine("1. Write a program to take an integer input from the user. " +
                        "Determine if the number is positive, negative, or zero. " +
                        "Display the result.");
                    
                    int number =int.Parse(Console.ReadLine());
                    if (number >= 0) Console.WriteLine("Positive");
                    else Console.WriteLine("Negative");
                    Console.ReadLine();
                    continue;
                }

                if (choice == 2)
                {
                    Console.WriteLine("2. Write a program to take three different numbers as input." +
                        " Determine the largest of the three numbers and display it.");
                    int number_1=0, number_2=0, number_3=0;
                    Console.WriteLine("Type number 1:");
                    number_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type number 2:");
                    number_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type number 3:");
                    number_2 = int.Parse(Console.ReadLine());

                    if ((number_1 > number_2) && (number_1 > number_3))
                    { Console.WriteLine($"The largest number is: {number_1}"); }
                    else if ((number_2 > number_1) && (number_2 > number_3))
                    { Console.WriteLine($"The largest number is: {number_2}"); }
                    else
                    { Console.WriteLine($"The largest number is: {number_3}"); }
                    Console.ReadLine();
                    continue;
                }

                if (choice == 3)
                {
                    Console.WriteLine("Write a program that takes an alphabet as input. Check " +
                        "whether the input is a vowel (a, e, i, o, u) or a consonant.");
                    Console.WriteLine("Enter a letter: ");
                    char letter = Convert.ToChar(Console.ReadLine());

                    letter = Char.ToLower(letter);

                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        Console.WriteLine("The entered alphabet is a vowel.");
                    }
                    else if ((letter >= 'a' && letter <= 'z') && !(letter == 'y'))
                    {
                        Console.WriteLine("The entered alphabet is a consonant.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid alphabet.");
                    }

                    Console.ReadLine();
                }

                if (choice == 4)
                {
                    Console.WriteLine("Write a program to print the multiplication table of a " +
                        "given number up to 10.\nAsk the user for a number, then print " +
                        "out the related multiplication table.");

                    Console.WriteLine("Please put some number: ");
                    int number = int.Parse(Console.ReadLine());
                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine($"{i}*{number}={(i * number)}");
                    }
                }


                if (choice == 5)
                {
                    Console.WriteLine("Write a program to determine if a given number is a " +
                        "prime number (a number only divisible by 1 and itself).");
                    {
                        Console.WriteLine("Enter a number: ");
                        int number = int.Parse(Console.ReadLine());
                        bool isPrime = IsPrime(number);
                        if (isPrime) { Console.WriteLine(number + " is a prime number."); }
                        else { Console.WriteLine(number + " is not a prime number."); }
                        Console.ReadLine();
                    }

                    static bool IsPrime(int num)
                    {
                        if (num <= 1) { return false; }
                        
                        for (int i = 2; i <= Math.Sqrt(num); i++)
                        {
                            if (num % i == 0) { return false; }
                        }
                       return true;
                    }
                }

                if (choice==6)
                {
                    Console.WriteLine("Write a program that prints the numbers from 1 to 100. " +
                        "However:\nFor multiples of three, print \"Fizz\" instead of the number." +
                        "\nFor multiples of five, print \"Buzz\".\r\nFor numbers that are multiples " +
                        "of both three and five, print \"FizzBuzz\".");

                    Console.WriteLine("Enter a number: ");
                    int number = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= number; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0) { Console.WriteLine("FizzBuzz"); }
                        else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
                        else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
                        else Console.WriteLine(i);
                    }
                    Console.ReadLine();
                }



                if (choice == 7)
                {
                    Console.WriteLine("Thanks that you use our program!");
                    break;
                }
            }
        }
    }
}