using System;
using System.ComponentModel;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Task5
{ 
    #region Problem1:
    public static void DivideNumbers()
    {
        try
        {
            Console.WriteLine("enter the first num (dividend)");
            int dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second num (divisor)");
            int divisor = int.Parse(Console.ReadLine());
            int result = dividend / divisor;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException) { Console.WriteLine("Error: Cannot divide by zero."); }
        catch (FormatException) { Console.WriteLine("Error: Invalid input. Please enter a valid integer."); }
        finally { Console.WriteLine("Operation complete"); }
    }
    #endregion

    #region Problem2:
    public static void TestDefensiveCode()
    {
        int X, Y, Z;
        do
        {
            Console.WriteLine("Enter first Positive Number: ");
        }
        while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
        do
        {
            Console.WriteLine("Enter Second Number: ");
        }
        while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

        Z = X / Y;
        Console.WriteLine($"Result (X / Y) = {Z}");
    }
    #endregion

    #region Problem3:
    public static void DemonstrateNullable(int? num)
    {
        int result = num ?? 10;
        Console.WriteLine($"Value using (??): {result}");

        Console.WriteLine($"HasValue: {num.HasValue}");
        Console.WriteLine(num.HasValue ? $"Value: {num.Value}" : "Cannot access .Value because variable is null");
    }
    #endregion

    #region Problem4:
    public static void TestArrayBounds()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        try
        {
            int val = numbers[5];
            Console.WriteLine($"Value at index 5: {val}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: Index is out of bounds.");
        }
    }
    #endregion

    #region Problem5:
    public static void ProcessMatrix()
    {
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Enter values for 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine(" Sum of Rows ");
        for (int i = 0; i < 3; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < 3; j++)
            {
                rowSum += matrix[i, j];
            }
            Console.WriteLine($"Row {i + 1} Sum = {rowSum}");
        }

        Console.WriteLine(" Sum of Columns ");
        for (int j = 0; j < 3; j++)
        {
            int colSum = 0;
            for (int i = 0; i < 3; i++)
            {
                colSum += matrix[i, j];
            }
            Console.WriteLine($"Column {j + 1} Sum = {colSum}");
        }
    }
    #endregion

    #region Problem6:
    public static void ProcessJaggedArray()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[2];
        jaggedArray[1] = new int[4];
        jaggedArray[2] = new int[3];

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine($"Enter {jaggedArray[i].Length} integers for Row {i + 1}:");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Row {i + 1}, Element {j + 1}: ");
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine(" Jagged Array Elements ");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write($"Row {i + 1}: ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"{jaggedArray[i][j]} ");
            }
            Console.WriteLine();
        }
    }
    #endregion

    #region Problem7:
    public static void ProNullableString()
    {
        string? name = null;

        Console.Write("Do you want to enter your name? (y/n): ");
        string choice = Console.ReadLine();

        if (choice?.ToLower() == "y")
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
        }

        if (name != null)
        {
            string nonNullName = name!;
            Console.WriteLine($"Hello, {nonNullName.ToUpper()}!");
        }
        else
        {
            Console.WriteLine("No name was provided.");
        }
    }

    #endregion

    #region Problem8:
    public static void DemonstrateBoxingAndUnboxing()
    {
        int num = 42;
        object boxedNum = num;
        Console.WriteLine($"Boxed value: {boxedNum}");

        int unboxedNum = (int)boxedNum;
        Console.WriteLine($"Unboxed value: {unboxedNum}");

        try
        {
            double invalidUnbox = (double)boxedNum;
            Console.WriteLine($"Invalid Unboxed value: {invalidUnbox}");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Error: InvalidCastException caught! Cannot unbox directly to a different type.");
        }
    }
    #endregion

    #region Problem9:
    public static void SumAndMultiply(int a, int b, out int sum, out int product)
    {
        sum = a + b;
        product = a * b;
    }
    #endregion

    #region Problem10:
    public static void PrintMessage(string text, int count = 5)
    {
        for (int i = 0; i < count; i++)
            Console.WriteLine($"{i + 1}. {text}");
    }
    #endregion

    #region Problem11:
    public static void ProcessNullableArray()
    {
        int[]? numbers = null;
        int? lengthWhenNull = numbers?.Length;
        Console.WriteLine($"Array Length when null: {lengthWhenNull?.ToString() ?? "null"}");

        numbers = new int[] { 10, 20, 30, 40 };

        int? lengthWhenNotNull = numbers?.Length;
        Console.WriteLine($"Array Length when initialized: {lengthWhenNotNull}");
    }
    #endregion

    #region Problem12:
    public static void GetDayNumber(string day)
    {
        switch (day.ToLower())
        {
            case "monday":
                Console.WriteLine("1");
                break;
            case "tuesday":
                Console.WriteLine("2");
                break;
            case "wednesday":
                Console.WriteLine("3");
                break;
            case "thursday":
                Console.WriteLine("4");
                break;
            case "friday":
                Console.WriteLine("5");
                break;
            case "saturday":
                Console.WriteLine("6");
                break;
            case "sunday":
                Console.WriteLine("7");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
    #endregion

    #region Problem13:
    public static int SumArray(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
    #endregion

    static void Main(string[] args)
    {
        //Problem1:
        //DivideNumbers();

        //Problem2:
        //TestDefensiveCode();

        //Problem3:
        //int? number = null;
        //DemonstrateNullable(number);

        //Problem4:
        //TestArrayBounds();

        //Problem5:
        //ProcessMatrix();

        //Problem6:
        //ProcessJaggedArray();

        //Problem7:
        //ProNullableString();

        //Problem8:
        //DemonstrateBoxingAndUnboxing();

        //Problem9:
        //int num1 = 5, num2 = 4;
        //int sumResult, productResult; 
        //SumAndMultiply(num1, num2, out sumResult, out productResult);
        //Console.WriteLine($"Numbers: {num1} and {num2}");
        //Console.WriteLine($"Sum = {sumResult}");
        //Console.WriteLine($"Product = {productResult}");

        //Problem10:
        //PrintMessage("Hello C#");
        //PrintMessage("Welcome", 3);
        //PrintMessage(count: 2, text: "Named Parameter");

        //Problem11:
        //ProcessNullableArray();

        //Problem12:
        //Console.Write("Enter a day of the week: ");
        //string day = Console.ReadLine();
        //GetDayNumber(day);

        //Problem13:
        //int sum1 = SumArray(10, 20, 30);
        //Console.WriteLine($"Sum of individual values (10, 20, 30): {sum1}");

        //int[] numbers = { 1, 2, 3, 4, 5 };
        //int sum2 = SumArray(numbers);
        //Console.WriteLine($"Sum of array elements: {sum2}");
    }
}

class Task5Part02
{
    #region Problem1:
    static void PrintNumbers()
    {
        Console.Write("Input: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
    }
    #endregion

    #region Problem2:
    static void PrintMultiplicationTable()
    {
        Console.Write("Input: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            int result = number * i;
            Console.Write(result + (i < 12 ? ", " : ""));
        }
    }
    #endregion

    #region Problem3:
    static void PrintEvenNumbers()
    {
        Console.Write("Input: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 2; i <= number; i += 2)
        {
            Console.Write(i + (i + 2 <= number ? ", " : ""));
        }
    }
    #endregion

    #region Problem4:
    static void CalculatePower()
    {
        Console.Write("Enter base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int expNum = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= expNum; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine($"Output: {result}");
    }
    #endregion

    #region Problem5:
    static void ReverseString()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        Console.WriteLine($"Output: \"{reversed}\"");
    }
    #endregion

    #region Problem6:
    static void ReverseInteger()
    {
        Console.Write("Input: ");
        int number = int.Parse(Console.ReadLine());
        int reversed = 0;
        while (number > 0)
        {
            int digit = number % 10;  
            reversed = (reversed * 10) + digit;
            number /= 10;
        }
        Console.WriteLine($"Output: {reversed}");
    }
    #endregion

    #region Problem7:
    static void FindMaxDistance()
    {
        Console.Write("Enter array elements separated by spaces: ");
        string[] input = Console.ReadLine().Split(' ');

        int maxDistance = 0;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = input.Length - 1; j > i; j--)
            {
                if (input[i] == input[j])
                {
                    int distance = j - i - 1;

                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                    }
                    break; 
                }
            }
        }
        Console.WriteLine($"Output: {maxDistance}");
    }
    #endregion

    #region Problem8:
    static void ReverseWords()
    {
        Console.Write("Input: ");
        string[] words = Console.ReadLine().Split(' ');
        Array.Reverse(words);
        Console.WriteLine($"Output: {string.Join(" ", words)}");
}
    #endregion
    static void Main(string[] args)
    {
        //PrintNumbers();
        //PrintMultiplicationTable();
        //PrintEvenNumbers();
        //CalculatePower();
        //ReverseString();
        //ReverseInteger();
        //FindMaxDistance();
        //ReverseWords();
    }
}

#region Questions:
//1.To ensure code executes (like closing resources or files) whether an exception occurs or not.

//2.It prevents runtime crashes (exceptions) if the input is invalid by returning false instead of throwing an error.

//3.InvalidOperationException

//4.To prevent an IndexOutOfRangeException and avoid runtime program crashes.

//5.It returns the number of elements in a specific dimension (0 for rows, 1 for columns).

//6.Rectangular array: Allocated as a single, contiguous block of memory in a single heap object.
//Jagged array: Allocated as an array of arrays—an array containing references to separate, non-contiguous sub-arrays on the heap.

//7.To help prevent NullReferenceException errors at compile-time by making code intent clear about whether a reference type can hold null.

//8.They degrade performance by causing garbage collection overhead (allocating value types on the heap) and CPU execution delays (type-checking and memory copying).

//9.Because the caller passes uninitialized variables, so the method guarantees they are assigned a value before returning.

//10.To prevent ambiguity so the compiler can accurately map positional arguments passed during the method call.

//11.It short-circuits evaluation: if the operand is null, it immediately evaluates to null without accessing the member, avoiding a NullReferenceException.

//12.When matching a single variable or expression against multiple values/patterns to return a value, offering cleaner and more concise syntax.

//13.Single Parameter: A method can have only one params parameter.
//Must Be Last: It must be the last parameter in the method's parameter list.
//One - Dimensional Arrays Only: It can only be applied to single-dimensional arrays (T[]).
#endregion