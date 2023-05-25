using System;

namespace Task5 {
    class Program {
        static void Main(string [] args) {
            Console.WriteLine("Enter your day of birth (dd/MM//yyyy): ");
            DateTime time = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", null);
            DateTime current = DateTime.Today;
            DateTime calTime = time.AddYears(current.Year - time.Year);

            float value = calTime.Subtract(current).Days;
            if (value <= 0) {
                Console.WriteLine($"Number of days to birthday: {value + 365}");
            }
            else {
                Console.WriteLine($"Number of days to birthday: {value}");
            }

            
        }
    }
}
