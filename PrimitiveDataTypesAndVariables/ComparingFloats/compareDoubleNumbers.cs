//Problem 13.* Comparing Floats

//    Write a program that safely compares floating-point numbers (double) 
//    with precision eps = 0.000001.
//    Note: Two floating-point numbers a and b cannot be compared directly by a == b 
//    because of the nature of the floating-point arithmetic. Therefore, we assume two numbers 
//    are equal if they are more closely to each other than a fixed constant eps.

using System;

class compareDoubleNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert value a:");
        double a = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
        Console.WriteLine("Insert value b:");
        double b = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        double esp = 0.000001;

        bool areEqual = Math.Abs(a - b) < esp;
        Console.WriteLine("Are a and b equal? --> {0}", areEqual);

    }
}

