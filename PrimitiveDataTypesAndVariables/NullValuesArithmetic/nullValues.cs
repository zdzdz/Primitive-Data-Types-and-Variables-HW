//Problem 12. Null Values Arithmetic

//    Create a program that assigns null values to an integer and to a double variable.
//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.


using System;

class nullvalues
{
    static void Main()
    {
        int? number = null;
        double? amountOfMoney = null;

        Console.WriteLine(number);
        Console.WriteLine(amountOfMoney);

        number += 5;
        amountOfMoney += 6;

        Console.WriteLine(number);
        Console.WriteLine(amountOfMoney);

        number += null;
        amountOfMoney += null;

        Console.WriteLine(number);
        Console.WriteLine(amountOfMoney);
    }
}

