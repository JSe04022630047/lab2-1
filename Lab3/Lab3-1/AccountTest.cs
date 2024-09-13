using System;

internal class AccountTest
{
    private static void Main(string[] args)
    {
        // Create an Account object and assign it to myAccount
        Account myAccount = new Account();

        // Display myAccount's initial name (there isn't one)
        Console.WriteLine($"Initial name is: {myAccount.GetName()}");

        // Prompt for and read the name, then put the name in the object
        Console.Write("Enter the name: "); // prompt
        string theName = Console.ReadLine(); // read the name
        myAccount.SetName(theName); // put theName in the myAccount object

        // Display the name stored in the myAccount object
        Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");

        Console.ReadLine();
    }
}