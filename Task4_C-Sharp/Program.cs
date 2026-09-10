using System;

enum DayOfWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7): ");

        if (int.TryParse(Console.ReadLine(), out int input) && input >= 1 && input <= 7)
        {
            DayOfWeek day = (DayOfWeek)input;
            Console.WriteLine($"Day: {day}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
        }



        /*If the user enters a number outside the 1–7 range (or invalid text like "abc"):

         Validation Catch: The input >= 1 && input <= 7 condition fails.

         Output: The program skips the enum cast, branches to the else block, and prints:

         "Invalid input! Please enter a number between 1 and 7."

         Program Safety: Prevents the system from printing invalid numeric mappings or crashing with an error.

         Technical Note on Enums: If you force-cast an invalid integer without validation like (DayOfWeek)99,
        C# will not throw an error—it will simply hold the raw value 99 and print the number 99 instead of a day name.
        That's why the range check (1 to 7) is mandatory.*/
    }
}