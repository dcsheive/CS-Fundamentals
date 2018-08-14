using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            Console.WriteLine($"Hello {place}");
            Console.WriteLine("jello"+121);
            Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim"); 
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");
            Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
        }
    }
}
