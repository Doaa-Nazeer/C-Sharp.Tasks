using System;

class Program
{
    static void Main()
    {
        #region Problem1:
        //// 1.Array Initialization Techniques
        //int[] numbersone = new int[3];

        //numbersone[0] = 10;
        //numbersone[1] = 20;
        //numbersone[2] = 30;

        //int[] numberstwo = new int[] { 40, 50, 60 };

        //int[] numbersthree = { 70, 80, 90 };

        //// 2. Modifying Values & Printing

        //numbersone[0] = 100;
        //numberstwo[1] = 200;
        //numbersthree[2] = 300;

        //Console.WriteLine("Array 1 (new int[size]):", numbersone);
        //Console.WriteLine("Array 2 (Initializer List):", numberstwo);
        //Console.WriteLine("Array 3 (Syntax Sugar):", numbersthree);

        //// 3.Demonstrating IndexOutOfRangeException

        //Console.WriteLine("Exception Handling Demonstration");
        //try
        //{
        //    Console.WriteLine("Attempting to access arrayOne[3]...");
        //    int invalidValue = numbersone[3];
        //}
        //catch (IndexOutOfRangeException ex)
        //{
        //    Console.WriteLine($"[Caught Exception]: {ex.Message}");
        //}
        //static void PrintArray(string label, int[] array)
        //{
        //    Console.WriteLine(label);
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine($"  Element at index {i}: {array[i]}");
        //    }
        //}
        #endregion

        #region Question1:
        /*he default values depend on the data type:
        Numeric types (int, double, etc.): 0
        Boolean (bool): false
        Reference types (string, objects): null
        Character (char): '\0' (null character)*/
        #endregion

        #region problem2:   
        //// Shallow Copy
        //Console.WriteLine("Shallow Copy");

        //string[] arr1 = { "A", "B", "C" };
        //string[] arr2 = arr1; 


        //Console.WriteLine($"arr1[0]: {arr1[0]}");    
        //Console.WriteLine($"arr2[0]: {arr2[0]}");

        //arr2[0] = "Z";

        //Console.WriteLine($"After modifying arr2[0]:");
        //Console.WriteLine($"arr1[0]: {arr1[0]}");
        //Console.WriteLine($"arr2[0]: {arr2[0]}");

        ////Deep Copy
        //Console.WriteLine("Deep Copy");

        //string[] arr3 = (string[])arr1.Clone();

        //Console.WriteLine($"arr1[0]: {arr1[0]}");
        //Console.WriteLine($"arr3[0]: {arr3[0]}");

        //arr3[0] = "Y";

        //Console.WriteLine($"After modifying arr3[0]:");
        //Console.WriteLine($"arr1[0]: {arr1[0]}");
        //Console.WriteLine($"arr3[0]: {arr3[0]}");
        #endregion

        #region Question2:
        /*Array.Clone(): Creates and returns a new array instance containing a copy of all elements. 
         * It requires casting the returned object to the target array type.

        Array.Copy(): Copies elements from an existing array to another already existing array. 
        It allows copying a specific range or subset of elements*/
        #endregion

        #region problem3:
        //int[,] grades = new int[3, 3];

        //Console.WriteLine(" Enter Student Grades ");
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine($"\nStudent {i + 1}:");
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.Write($"Enter grade for Student {i + 1}, Subject {j + 1}: ");
        //        grades[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}

        //for (int i = 0; i < grades.GetLength(0); i++)
        //{
        //    Console.Write($"Student {i + 1} Grades: ");
        //    for (int j = 0; j < grades.GetLength(1); j++)
        //    {
        //        Console.Write($"{grades[i, j]}\t");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region Question3:
        /*Length: Returns the total number of elements across all dimensions combined.

        GetLength(dimension): Returns the number of elements in a specific dimension (0 for rows, 1 for columns)*/
        #endregion

        #region problem4:
        //int[] originalArray = { 45, 12, 89, 23, 67 };

        //Console.WriteLine(" INITIAL ARRAY ");
        //Console.WriteLine("Original", originalArray);

        //Console.WriteLine(" Array.Sort");
        //Console.WriteLine("Explanation: Rearranges elements from smallest to largest.");
        //int[] numbers = (int[])originalArray.Clone(); 
        //Array.Sort(numbers);
        //Console.WriteLine("After Sort", numbers);

        //Console.WriteLine(" Array.Reverse ");
        //Console.WriteLine("Explanation: Inverts the current sequence of elements.");
        //Array.Reverse(numbers);
        //Console.WriteLine("After Reverse", numbers);

        //Console.WriteLine(" Array.IndexOf ");
        //Console.WriteLine("Explanation: Searches for the value 89 and returns its position index.");
        //int target = 89;
        //int index = Array.IndexOf(numbers, target);
        //Console.WriteLine($"Result: Found {target} at index [{index}].");

        //Console.WriteLine("\n=== 4. Array.Copy ===");
        //Console.WriteLine("Explanation: Copies the first 3 elements into a newly allocated destination array.");
        //int[] destination = new int[3];
        //Array.Copy(numbers, destination, 3);
        //Console.WriteLine("Destination Array (After Copy)", destination);

        //Console.WriteLine("\n=== 5. Array.Clear ===");
        //Console.WriteLine("Explanation: Resets elements from index 1 to 3 back to 0 (default int value).");
        //Array.Clear(numbers, 1, 3);
        //Console.WriteLine("After Clear", numbers);

        //static void PrintArray(string label, int[] arr)
        //{ Console.WriteLine($"{label}: [{string.Join(", ", arr)}]");}
        #endregion

        #region Question4:
        /*Array.Copy(): Copies elements from one array to another. 
        If an exception occurs mid-operation (e.g., type mismatch), partial copying occurs, 
        leaving the target array in a corrupted/half-copied state.

        Array.ConstrainedCopy(): Guarantees atomic operation ("all-or-nothing"). 
        Before copying, it validates that all types and boundaries match. If an error occurs,
        it rolls back, leaving the target array completely untouched.*/
        #endregion

        #region problem5:
        //int[] numbers = { 10, 20, 30, 40, 50 };

        //Console.WriteLine("=== 1. Print using 'for' loop ===");
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine($"Element at index {i}: {numbers[i]}");
        //}

        //Console.WriteLine("\n=== 2. Print using 'foreach' loop ===");
        //foreach (int number in numbers)
        //{
        //    Console.WriteLine($"Element: {number}");
        //}

        //Console.WriteLine("\n=== 3. Print in reverse order using 'while' loop ===");
        //int index = numbers.Length - 1; 

        //while (index >= 0)
        //{
        //    Console.WriteLine($"Element at index {index}: {numbers[index]}");
        //    index--; 
        //}
        #endregion

        #region Question5:
        /*Safety & Immutability: The iteration variable is read-only, preventing accidental modification of array elements.

        No Index Out-of-Bounds: Eliminates off-by-one errors since boundary checks and index increments are managed automatically.

        Cleaner Syntax: Cleaner and easier to read without boilerplate counter initialization or array indexing logic.*/
        #endregion

        #region problem6:
        //int number;
        //bool isValidInput;

        //do
        //{
        //    Console.Write("Please enter a positive odd number: ");
        //    string input = Console.ReadLine();

        //    bool isInteger = int.TryParse(input, out number);

        //    if (isInteger && number > 0 && number % 2 != 0)
        //    {
        //        isValidInput = true;
        //    }
        //    else
        //    {
        //        isValidInput = false;

        //        Console.ForegroundColor = ConsoleColor.Red;
        //        if (!isInteger)
        //        {
        //            Console.WriteLine("Invalid input! Please enter a valid whole number.");
        //        }
        //        else if (number <= 0)
        //        {
        //            Console.WriteLine("Invalid input! The number must be greater than zero.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input! The number must be odd.");
        //        }
        //        Console.ResetColor();
        //        Console.WriteLine();
        //    }

        //} while (!isValidInput);

        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine($"\nSuccess! You entered a valid positive odd number: {number}");
        //Console.ResetColor();
        #endregion

        #region Question6:
        /*Prevents Application Crashes: Prevents unhandled runtime exceptions 
        (e.g., FormatException from bad string-to-number parses or OverflowException).

        Protects Program Logic: Ensures input values conform to domain rules 
        (e.g., preventing negative array sizes or division by zero).

        Security & System Integrity: Guarantees bad, malicious, or malformed user data 
        cannot corrupt system state or compromise security.

        Improves User Experience: Delivers immediate, meaningful feedback to help 
        users correct invalid inputs cleanly.*/
        #endregion

        #region problem7:
        //int[,] matrix = {
        //    { 1,  2,  3,  4 },
        //    { 5,  6,  7,  8 },
        //    { 9, 10, 11, 12 }
        //};

        //Console.WriteLine("=== Matrix Output (3x4) ===");

        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write($"{matrix[i, j]}\t");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region Question7:
        /*Use Tab Spacing (\t): Aligns column entries into even columns automatically
         using Console.Write($"{matrix[i, j]}\t").

        Use Fixed-Width Formatting: Guarantees uniform alignment for numbers of varying digit
        lengths using string formatting like Console.Write($"{matrix[i, j], 5}") (pads to 5 spaces).

        Insert Row Line Breaks: Print Console.WriteLine() 
        after the inner column loop finishes to separate each row visually.

        Add Grid Borders/Headers: Print row indices, column labels,
        or horizontal divider lines (---) to ground the matrix visually.*/
        #endregion

        #region problem8:

        //Console.Write("Enter a month number (1-12): ");
        //if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
        //{
        //    Console.WriteLine("Invalid input! Please enter an integer between 1 and 12.");
        //    return;
        //}

        //string monthNameIfElse;

        //if (month == 1) monthNameIfElse = "January";
        //else if (month == 2) monthNameIfElse = "February";
        //else if (month == 3) monthNameIfElse = "March";
        //else if (month == 4) monthNameIfElse = "April";
        //else if (month == 5) monthNameIfElse = "May";
        //else if (month == 6) monthNameIfElse = "June";
        //else if (month == 7) monthNameIfElse = "July";
        //else if (month == 8) monthNameIfElse = "August";
        //else if (month == 9) monthNameIfElse = "September";
        //else if (month == 10) monthNameIfElse = "October";
        //else if (month == 11) monthNameIfElse = "November";
        //else monthNameIfElse = "December";

        //Console.WriteLine($"\n[if-else Result]: Month {month} is {monthNameIfElse}");

        //string monthNameSwitch;

        //switch (month)
        //{
        //    case 1: monthNameSwitch = "January"; break;
        //    case 2: monthNameSwitch = "February"; break;
        //    case 3: monthNameSwitch = "March"; break;
        //    case 4: monthNameSwitch = "April"; break;
        //    case 5: monthNameSwitch = "May"; break;
        //    case 6: monthNameSwitch = "June"; break;
        //    case 7: monthNameSwitch = "July"; break;
        //    case 8: monthNameSwitch = "August"; break;
        //    case 9: monthNameSwitch = "September"; break;
        //    case 10: monthNameSwitch = "October"; break;
        //    case 11: monthNameSwitch = "November"; break;
        //    case 12: monthNameSwitch = "December"; break;
        //    default: monthNameSwitch = "Unknown"; break;
        //}

        //Console.WriteLine($"[switch Result] : Month {month} is {monthNameSwitch}");
        #endregion

        #region Question8:
        /*Multiple Discrete Equality Checks: Comparing a single variable against 
         a fixed list of constant values (e.g., enums, integers, strings).

        Code Readability & Maintainability: Replaces long chains of repetitive else if
        (x == ...) with a clean, flat table-like structure.

        Compiler Optimization: Compiles to a lookup/jump table for large sets of integral/enum values,
        outperforming sequential if-else evaluations.

        Pattern Matching (C# 8+): Matching multi-property conditions, types, or tuple states cleanly 
        using modern switch expressions.*/
        #endregion

        #region problem9:
        //int[] numbers = { 42, 15, 88, 15, 23, 88, 7, 15 };

        //Console.WriteLine("Sorting)");

        //Array.Sort(numbers);

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write(numbers[i] + " ");
        //}
        //Console.WriteLine("\n");

        //Console.WriteLine("Searching)");

        //int target = 15;

        //int firstIndex = Array.IndexOf(numbers, target);

        //int lastIndex = Array.LastIndexOf(numbers, target);

        //Console.WriteLine( target);

        //if (firstIndex != -1)
        //{
        //    Console.WriteLine(firstIndex);
        //    Console.WriteLine(lastIndex);
        //}
        //else
        //{
        //    Console.WriteLine("num is not valed");
        //}
        #endregion

        #region Question9:
        /*Time Complexity: $\mathcal{O}(n \log n)$ on average and worst-case.Algorithm:
         Introsort (Introductory Sort)—a hybrid algorithm that starts with QuickSort,
         switches to HeapSort if the recursion depth exceeds a threshold, and uses 
         InsertionSort for small partitions (fewer than 16 elements).*/
        #endregion

        #region problem10:

        //int[] numbers = { 10, 20, 30, 40, 50 };

        //int sumFor = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sumFor += numbers[i];
        //}
        //Console.WriteLine($"Sum using 'for' loop    : {sumFor}");

        //int sumForEach = 0;
        //foreach (int number in numbers)
        //{
        //    sumForEach += number;
        //}
        //Console.WriteLine($"Sum using 'foreach' loop: {sumForEach}");

        #endregion

        #region Question10:
        /*for loop is slightly more efficient (or identical in performance after JIT optimization).

        Why for is more efficient
        Index Access Directness: A for loop accesses array memory directly via an integer index (array[i]).

        JIT Bounds-Check Elimination: The .NET Just-In-Time (JIT) compiler recognizes the standard
        for (int i = 0; i < array.Length; i++) pattern and completely removes array boundary checks during iteration.

        No Enumerator Allocation: A foreach loop behind the scenes creates an enumerator 
        or struct iterator overhead (though for single-dimensional arrays, the JIT optimizes
        foreach down to a standard for loop, eliminating the gap in modern .NET).*/
        #endregion

    }
}
