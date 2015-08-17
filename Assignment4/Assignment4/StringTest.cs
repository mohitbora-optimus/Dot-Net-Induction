using System;

class StringTest
{
    static void Main(string[] args)
    {
        string FirstName = "rahul";
        string LastName = "singh";

        Console.WriteLine(FirstName + " " + LastName);
        Console.WriteLine(String.Concat(FirstName," ", LastName));
        if (FirstName.Contains(LastName))
            Console.WriteLine("\n FirstName is Contained within Lastname");
        else
            Console.WriteLine("\n FirstName is not Contained within Lastname");

        Console.WriteLine(FirstName.ToUpper() + " "+ LastName.ToLower());

        Console.WriteLine(FirstName.Substring(2));

        Console.WriteLine(String.Compare(FirstName, LastName));
        Console.ReadKey();
    }
}
