using System;

namespace Task3 {
    class Program {
        static void Main(string [] args) {
            Console.WriteLine("Enter your name: ");
            string? name = Console.ReadLine();
            Console.Write("Hello: {0}", name);
        }
    }
}
