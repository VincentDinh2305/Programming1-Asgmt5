using System;

namespace _06_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Year     Balance");
            Console.WriteLine("----     ---------");
            int year = 1;
            double balance = 1000, decM = 1.08, money = 1000 * decM;
            do
            {
                Console.WriteLine($"{year,3} {money,14:C}");
                money = money * decM;
                year += 1;
                balance += decM;
            } while (year <= 10);

        }
    }
}
