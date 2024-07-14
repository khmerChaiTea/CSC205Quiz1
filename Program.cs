using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Quiz1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Get the full path of the executable file
            string executablePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // Print the full path to the console
            Console.WriteLine("Executable Path: " + executablePath);

            // Optionally, you can pause the console so the user can see the output
            Console.ReadLine();

            Console.WriteLine();
        }
    }
}
