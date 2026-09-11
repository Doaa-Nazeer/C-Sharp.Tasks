using System;

namespace Task6
{

    #region Problem 01:
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    #endregion

    #region Problem 02:
    public class TypeA
    {
        private int F = 10;
        internal int G = 20;
        public int H = 30;

        public void AccessWithinClass()
        {
            Console.WriteLine($"Inside Class -> F: {F}, G: {G}, H: {H}");
        }
    }

    public class TypeATest
    {
        public static void DemonstrateAccess()
        {
            TypeA obj = new TypeA();
            // Console.WriteLine(obj.F); // Error: 'F' is private (accessible only within TypeA)
            Console.WriteLine($"Internal G: {obj.G}"); // Allowed: same assembly
            Console.WriteLine($"Public H: {obj.H}");     // Allowed: everywhere
        }
    }
    #endregion

    #region Problem 03:
    public struct Employee
    {
        private int empId;
        private string name;
        private decimal salary;

        public Employee(int id, string name, decimal salary)
        {
            this.empId = id;
            this.name = name;
            this.salary = salary < 0 ? 0 : salary;
        }
        public string GetName() => name;
        public void SetName(string value) => name = value;
        public int EmpId
        {
            get => empId;
            set => empId = value;
        }
        public decimal Salary
        {
            get => salary;
            set => salary = value >= 0 ? value : 0; // Validation logic
        }
    }
    #endregion

    #region Problem 04:
    public struct Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x)
        {
            X = x;
            Y = 0;
        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    #endregion

    #region Problem 05:
    public struct FormattedPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public FormattedPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Point Coordinates -> X: {X} | Y: {Y}";
        }
    }
    #endregion

    #region Problem 06:
    public struct PointValue
    {
        public int X;
        public PointValue(int x) => X = x;
    }
    public class EmployeeRef
    {
        public decimal Salary;
        public EmployeeRef(decimal salary) => Salary = salary;
    }
    public class ProgramDemo
    {
        public static void ModifyValue(PointValue p)
        {
            p.X = 100; // Modifies copy only
        }

        public static void ModifyReference(EmployeeRef e)
        {
            e.Salary = 5000; // Modifies original object on Managed Heap
        }
    }
    #endregion

    public class Program
    {
        public static void Main(string[] args)
        {
            // Problem 01
            Point p1 = new Point(5, 10);
            Console.WriteLine($"Problem 01: {p1}");

            // Problem 02
            Console.WriteLine("Problem 02:");
            TypeATest.DemonstrateAccess();

            // Test Problem 03
            Employee emp = new Employee(101, "Doaa", 4500);
            emp.SetName("Doaa Mohamed");
            emp.Salary = 5000;
            Console.WriteLine($"Problem 03: Emp ID: {emp.EmpId}, Name: {emp.GetName()}, Salary: {emp.Salary}");

            // Problem 04
            Point2D ptA = new Point2D(7);
            Point2D ptB = new Point2D(7, 14);
            Console.WriteLine($"Problem 04: Overload 1 ({ptA.X}, {ptA.Y}) | Overload 2 ({ptB.X}, {ptB.Y})");

            // Problem 05
            FormattedPoint fp1 = new FormattedPoint(3, 4);
            FormattedPoint fp2 = new FormattedPoint(12, 25);
            Console.WriteLine($"Problem 05:\n  {fp1}\n  {fp2}");

            // Problem 06
            PointValue valObj = new PointValue(10);
            ProgramDemo.ModifyValue(valObj);

            EmployeeRef refObj = new EmployeeRef(2000);
            ProgramDemo.ModifyReference(refObj);

            Console.WriteLine($"Problem 06: Struct Value (Unchanged): {valObj.X} | Class Reference (Changed): {refObj.Salary}");
        }
    }
}

/*

Q1: Why can't a struct inherit from another struct or class in C#?
A: Structs are sealed value types designed for lightweight, fixed-size data stored directly on the Stack. Allowing inheritance would introduce dynamic memory dispatch and object slicing overhead. (All structs implicitly inherit only from System.ValueType / System.Object).

Q2: How do access modifiers impact the scope and visibility of a class member?
A: Access modifiers determine accessibility scope across types and assemblies:
   - private: Accessible only inside the declaring class/struct.
   - protected: Accessible inside the declaring class and derived subclasses.
   - internal: Accessible anywhere within the same assembly (.csproj).
   - public: Accessible without restriction across all assemblies.

Q3: Why is encapsulation critical in software design?
A: Encapsulation protects an object's internal state from unauthorized or invalid modifications, centralizes business validation logic, and reduces system coupling by concealing internal implementation details.

Q4: What is constructors in structs?
A: Special methods invoked during instantiation to initialize a struct's fields. Unlike classes, structs always have a default memory layout, and custom parameterized constructors must explicitly assign all struct fields before execution finishes.

Q5: How does overriding methods like ToString() improve code readability?
A: Overriding ToString() substitutes default runtime type string outputs (e.g., "Namespace.Point") with customized, human-readable data representation, simplifying logging and debugging.

Q6: How does memory allocation differ for structs and classes in C#?
A: 
   - Structs (Value Types): Allocated directly on the Stack (or inline inside containing types). Memory allocation is cheap, out-of-scope cleanup is instantaneous, and assignments pass copies of data.
   - Classes (Reference Types): Allocated on the Managed Heap, accessed via reference pointers on the stack, cleaned up periodically by the Garbage Collector (GC), and passed by reference.


--- PART 02 QUESTIONS ---

Q7: What is copy constructor?
A: A constructor that accepts another instance of the same type as a parameter and initializes a new object by cloning the values of the existing instance.

Q8: LinkedIn Article Structure Outline (Constructors & Types):
   - Headline: "Demystifying C# Constructors: Types, Scopes & Best Practices"
   - Introduction: Brief overview of object initialization in .NET.
   - Core Constructor Types Explained:
     1. Default Constructor: Initializes fields to implicit default values.
     2. Parameterized Constructor: Injects explicit values upon object creation.
     3. Static Constructor: Runs automatically once per type before any static members or instances are accessed.
     4. Private Constructor: Restricts object instantiation externally (ideal for Singleton patterns or static utility classes).
     5. Copy Constructor: Clones existing state into a new object reference.
   - Summary/Takeaway: Selecting the right constructor pattern guarantees clean architecture, immutability, and thread safety.

Q9: What is Indexer, when used, as business mention cases u have to utilize it?
A: An indexer allows instances of a class or struct to be accessed using array indexing syntax (`this[index]`).
   - Business Use Cases:
     1. E-Commerce Shopping Cart: Access items via SKU string or index (`cart["PROD-102"]`).
     2. Configuration Management: Retrieve application properties dynamically (`config["AppDbConnection"]`).
     3. Financial / Stock Portfolio: Query asset quantities by symbol (`portfolio["AAPL"]`).

Q10: Summarize keywords we have learnt last lecture:
   - struct: Declares a value type allocated on the Stack.
   - class: Declares a reference type managed on the Heap.
   - override: Replaces/extends inherited virtual methods (e.g., ToString).
   - new: Creates instances of types or hides inherited base class members.
   - this: Refers to the current instance of a class/struct.
   - private / public / internal: Set access permissions for members and types.
   - get / set: Define read and write accessors inside C# properties and indexers.
*/