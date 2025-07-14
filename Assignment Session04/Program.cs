

using System;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("insert an integr number");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region  Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter an integer to print its multiplication table: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nMultiplication Table for {number}:");

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($" {number * i}");
            //}



            #endregion

            #region Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter an integer : ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.

            //Console.Write("Enter the number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= exponent; i++)
            //{
            //    result *= num;
            //}

            //Console.WriteLine($"{num}^{exponent} = {result}");
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int[] marks = new int[5];

            //Console.WriteLine("Enter marks for 5 subjects:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Subject {i + 1}: ");
            //    marks[i] = int.Parse(Console.ReadLine());
            //}

            //int total = 0;
            //foreach (int mark in marks)
            //{
            //    total += mark;
            //}

            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine($"Total Marks = {total}");
            //Console.WriteLine($"Average Marks = {average:F2}");
            //Console.WriteLine($"Percentage = {percentage:F2}%");
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i]; 
            //}

            //Console.WriteLine($"Reversed string: {reversed}");
            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.???????
            
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;            
            //    reversed = reversed * 10 + digit;  
            //    number /= 10;                       
            //}

            //Console.WriteLine($"Reversed number: {reversed}");

            #endregion
            #region or 7

            Console.Write("Enter an integer: ");
            string num = Console.ReadLine();
            string reversed = "";

            for (int i = num.Length - 1; i >= 0; i--)
            {
                reversed += num.Substring(i, 1); 
            }

            Console.WriteLine($"Reversed number: {reversed}");
            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Prime numbers between {start} and {end}:");

            //for (int num = start; num <= end; num++)
            //{
            //    if (num < 2)
            //        continue;

            //    bool isPrime = true;

            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(num + " ");
            //    }
            //}

            //Console.WriteLine();
            #endregion

            #region 9 - .Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());

            //int original = number; 
            //string binary = "";

            //if (number == 0)
            //{
            //    binary = "0";
            //}
            //else
            //{
            //    while (number > 0)
            //    {
            //        int remainder = number % 2;
            //        binary = remainder + binary; 
            //        number = number / 2;
            //    }
            //}

            //Console.WriteLine($"The Binary of {original} is {binary}");

            #endregion


            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("Enter coordinates of point 1 (x1 y1): ");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates of point 2 (x2 y2): ");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates of point 3 (x3 y3): ");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //bool isCollinear = (y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1);

            //if (isCollinear)
            //    Console.WriteLine("The points lie on the same straight line.");
            //else
            //    Console.WriteLine("The points do NOT lie on the same straight line.");
            #endregion

            #region 11- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nIdentity Matrix of size {n}x{n}:\n");

            //for (int i = 0; i < n; i++)        
            //{
            //    for (int j = 0; j < n; j++)     
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }

    }
}