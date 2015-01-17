//Problem 11. Bank Account Data

//    A bank account has a holder name (first name, middle name and last name), 
//    available amount of money (balance), bank name, IBAN, 3 credit card numbers 
//    associated with the account.
//    Declare the variables needed to keep the information for a single bank account 
//    using the appropriate data types and descriptive names.


using System;

class bankAccount
{
    static void Main()
    {
        string firstName = "Simeon";
        string middleName = "Nikolov";
        string lastName = "Ivanov";
        string holderName = firstName + " " + middleName + " " + lastName;
        double balance = 200956.54;
        string bankname = "Super Bank";
        string IBAN = "BG72IASO45769831789522";
        long creditCard1 = 9932560221560265;
        long creditCard2 = 5324978451236120;
        long creditCard3 = 6974125641321045;

        Console.WriteLine("Holder Name: {0}", holderName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Bank Name: {0}", bankname);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.WriteLine("Credit Card 1: {0}", creditCard1);
        Console.WriteLine("Credit Card 2: {0}", creditCard2);
        Console.WriteLine("Credit Card 3: {0}", creditCard3);
      
    }
}

