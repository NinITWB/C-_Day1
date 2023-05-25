using System;

namespace Task2 {
    class Program {
        static void Main(string [] args) {
            Console.Write("Enter the width: ");
            float width = float.Parse(Console.ReadLine()!);
            
            Console.Write("Enter the length: ");
            float length = float.Parse(Console.ReadLine()!);

            Console.Write($"The area of rectangle is: {width * length}");
        }
    }
}
