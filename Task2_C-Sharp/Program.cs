using System;

static class Program
{
    static void Main()
    {
        #region Problem1
        /*This program declares two integer variables,
        calculates their sum */

        //int x = 10;  // First addend
        //int y = 20;  // Second addend
        //int sum = x + y;  // Calculates the total of x and y
        //Console.WriteLine(sum); // Prints 30  
        #endregion

        #region Question1

        //Comment block: Ctrl + K, Ctrl + C
        //Uncomment block: Ctrl + K, Ctrl + U

        #endregion

        #region Problem2
        // Fixed Code:
        //int x = 10; // Fixed string assignment to int
        //int y = 20; // Declared missing variable y
        //Console.WriteLine(x + y); // Capitalized 'Console'
        #endregion

        #region Question2
        //Runtime Error: An error that occurs while the program is executing, causing it to crash unexpectedly(e.g., attempting to divide by zero: int result = 10 / 0;).

        //Logical Error: The program runs without crashing, but it produces an incorrect or unexpected output due to faulty logic(e.g., calculating average using x +y / 2 instead of(x +y) / 2).
        #endregion

        #region Problem3
        //string FName = "Doaa Mohamed";
        //int age = 20;
        //decimal Salary = 20000;
        //bool Stu = true;
        #endregion

        #region Question3
        /*Following conventions like PascalCase (for classes/methods)
         * and camelCase (for local variables) improves code readability,
         * ensures consistency across development teams, and aligns with 
         * Microsoft's official C# standards, making code maintenance 
         * faster and less prone to mistakes.*/
        #endregion

        #region Problem4
        //Point P1;
        //P1 = new Point(10, 20);
        //Point P2;
        //P2 = new Point(30, 40);
        //P2 = P1; // Assigns the value of P1 to P2
        #endregion

        #region Question4
        /*Value Types (e.g., int, bool, struct): Stored directly on the Stack.
        Assigning a value type creates a distinct, independent copy of the value.

        Reference Types (e.g., string, class, array): The actual object data is 
        stored on the Heap, while a reference (memory address pointing to the object)
        is stored on the Stack. Copying a reference type duplicates the address, meaning 
        multiple variables point to the same underlying data on the Heap.*/
        #endregion

        #region Problem5
        //int x = 15; 
        //int y = 4;
        //Console.WriteLine(x + y); // Sum
        //Console.WriteLine(x - y); // Difference
        //Console.WriteLine(x * y); // Product
        //Console.WriteLine(x / y); // Division
        //Console.WriteLine(x % y); // Remainder
        #endregion

        #region Question5
        /*Output: 2

        Reason: The modulo operator (%) calculates the remainder of
        integer division. When diving 2 by 7, 7 fits into 2 zero times,
        leaving the entire dividend (2) as the remainder.*/
        #endregion

        #region Problem6
        //int x = 12;
        //if (x > 10 && x % 2 == 0)
        //    Console.WriteLine("x is greater than 10 and even");
        //else
        //    Console.WriteLine("x is not greater than 10 or not even");
        #endregion

        #region Question6
        /* && (Logical AND): Short-circuits execution. 
         If the left operand evaluates to false, 
         the right operand is completely skipped 
         because the final result must be false.

        & (Bitwise / Logical Non-Short-Circuiting AND):
        Always evaluates both sides regardless of the outcome.
        When applied to integers, it performs bitwise operations
        on individual bits.*/
        #endregion

        #region Problem7
        //double x = 5.2;
        //int y = (int)x; // Explicitly cast double to int
        //Console.WriteLine(y); 
        #endregion

        #region Question7
        /*Explicit casting is required because converting a
        double to an int risks data loss (truncating fractional values).
        C# requires developers to explicitly acknowledge this potential loss
        using the cast operator (int).*/
        #endregion

        #region Problem8
        //Console.Write("Enter your age: ");
        //string input = Console.ReadLine();

        //int age = int.Parse(input); // Convert string input to integer
        //if (age > 0)
        //    Console.WriteLine(age);
        //else
        //    Console.WriteLine("Invalid age entered.");
        #endregion

        #region Question8
        /*Following conventions like PascalCase (for classes/methods)
        and camelCase (for local variables) improves code readability,
        ensures consistency across development teams, and aligns with 
        Microsoft's official C# standards, making code maintenance 
        faster and less prone to mistakes.*/
        #endregion

        #region Problem9
        //int x = 10;
        //int Pre_X = x++;
        //Console.WriteLine(Pre_X);
        //int post_X = ++x;
        //Console.WriteLine(post_X);
        #endregion

        #region Question9
        /*Final value 7
            Evaluation sequence:
            ++x (Prefix): Increments x from 5 to 6 immediately and returns 6.
            x++ (Postfix): Reads the current value of x (6) for the addition, then increments x to 7.
            Expression becomes 6 + 6, assigning 12 to y.
            Final state: x equals 7; y equals 12.*/
        #endregion
    }
}

