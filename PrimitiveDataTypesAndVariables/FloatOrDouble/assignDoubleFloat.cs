﻿//Problem 2. Float or Double?

//    Which of the following values can be assigned to a variable of type float and which 
//    to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//    Write a program to assign the numbers in variables and print them to ensure 
//    no precision is lost.


using System;

class assignDoubleFloat
{
    static void Main()
    {
        double AConstant = 34.567839023;
        float BConsant = 12.345f;
        double CConstant = 8923.1234857;
        float DConstant = 3456.091f;

        Console.WriteLine(AConstant);
        Console.WriteLine(BConsant);
        Console.WriteLine(CConstant);
        Console.WriteLine(DConstant);

    }
}

