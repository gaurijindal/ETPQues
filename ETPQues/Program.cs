//b) C# Program to Display Months of the Year:

//using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        Console.WriteLine("Months of the Year:");
        foreach (string month in months)
        {
            Console.WriteLine(month);
        }
    }
}

// b) WAP using c# to display prime numbers upto 200.

//using System;
class PrimeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers up to 200:");

        for (int num = 2; num <= 200; num++)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(num + " ");
            }
        }

        Console.WriteLine();
    }
}

// a) Write a C# function to find the sum of digits of a given number.

//using System;

class Program
{
    static int SumOfDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10; // Add the last digit to sum
            number /= 10;       // Remove the last digit from the number
        }

        return sum;
    }

    static void Main(string[] args)
    {
        int number = 12345;
        int sum = SumOfDigits(number);
        Console.WriteLine("Sum of digits of " + number + " is: " + sum);
    }
}

//WAP using c# in which you have to display fibonacci series.

using System;

class Program
{
    static void FibonacciSeries(int n)
    {
        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            if (i <= 1)
                next = i;
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.Write(next + " ");
        }
    }

    static void Main(string[] args)
    {
        int n = 10; // Number of terms in the Fibonacci series
        FibonacciSeries(n);
    }
}

// a)Write a C# program to count the occurrences of a specific character in a given string. 
using System;

class Program
{
    static int CountOccurrences(string str, char ch)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (c == ch)
                count++;
        }

        return count;
    }

    static void Main(string[] args)
    {
        string inputString = "Hello, world!";
        char targetChar = 'o';

        int occurrences = CountOccurrences(inputString, targetChar);

        Console.WriteLine($"The character '{targetChar}' occurs {occurrences} times in the string.");
    }
}


