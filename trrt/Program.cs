using System;

namespace trrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random press = new Random();
            int returnvalue = press.Next(1, 100);

             Console.WriteLine("Skriv vilket tal du vill men det måste vara mellan 1-100: ");
            int.TryParse(Console.ReadLine(), out int x);
            Console.WriteLine("Skriv vilket tal du vill: ");
            int.TryParse(Console.ReadLine(), out int y);
            Console.WriteLine("Skriv vilket tal du vill för den sista gången: ");
            int.TryParse(Console.ReadLine(), out int z);
            int sum1 = (x+y) * z;
            int sum2 = x * y + y * z;
            Console.WriteLine("First calculation: " + sum1);
            Console.WriteLine("Second calculation: " + sum2);
        }
    }
}
