//Problem 1. Declare Variables

//    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
//    int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.


using System;

class AssignVaribles
{
    static void Main()
    {
        ushort hours = 52130;
        sbyte degrees = -115;
        int dollars = 4825932;
        byte workers = 97;
        short loss = -10000;

        Console.WriteLine(hours);
        Console.WriteLine(degrees);
        Console.WriteLine(dollars);
        Console.WriteLine(workers);
        Console.WriteLine(loss);

    }
}

