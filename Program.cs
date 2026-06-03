using System;

namespace Assignment9_Inheritance
{
    /// <summary>
    /// Runner class — creates a Campus object and displays its information.
    /// Demonstrates inheritance and method overriding from the DSC base class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DSC Campus Information ===\n");

            // Create a Campus object — inherits from DSC
            Campus atc = new Campus("Advanced Technology College");

            // ToString() override is called — prints campus-specific output
            Console.WriteLine(atc.ToString());

            Console.WriteLine("\nPress any key to exit...");
            Console.Read();
        }
    }
}
