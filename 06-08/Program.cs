using System;

namespace _06_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting Fahrenheit value: ");
            double startF = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter ending Fahrenheit value: ");
            double endF = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter increment value: ");
            double incr = Convert.ToDouble(Console.ReadLine());
            double cel;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Fahreheit     Celius");
            Console.WriteLine("---------     ------");
            while (startF >= endF)
            {
                cel = (startF - 32) *5 / 9;
                Console.WriteLine($"{startF,5} {cel,14:f}");
                startF -= incr;
            };
        }
    }
}
