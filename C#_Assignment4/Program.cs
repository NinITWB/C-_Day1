using System;

namespace Task4 {
    class Program {
        const float EXCHANGE_RATE = 23.485f;
        static void Main(string [] agrs) {
            Console.Write("Enter the amount in US's currency{$}: ");
            float dolar = float.Parse(Console.ReadLine()!);

            Console.Write($"The amount in VietNam's currency is: {dolar * EXCHANGE_RATE}VND");
        }
    }
}
