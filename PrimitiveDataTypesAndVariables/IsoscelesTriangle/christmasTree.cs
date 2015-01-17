//Problem 8. Isosceles Triangle

//    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:


using System;

class christmastTree
{
    static void Main()
    {
        char symbol = '©';

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("   " + symbol);
        Console.WriteLine("  " +"{0}" + " " + "{0}", symbol);
        Console.WriteLine(" " + "{0}" + " " + " " + " " + "{0}", symbol);
        Console.WriteLine("{0}" + " " + "{0}" + " " +"{0}" + " " + "{0}", symbol);
       
    }
}

