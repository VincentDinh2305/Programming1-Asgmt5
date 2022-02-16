using System;

namespace _05_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 10, endNum = 1, decre = 1, squares, cubes;
            Console.WriteLine("Number    Square    Cube");
            Console.WriteLine("------    ------    ----");
            while (Num >0)
            {
                squares = Num * Num;
                cubes = Num * Num * Num;
                Console.WriteLine($"{Num,5} {squares,9} {cubes,8}");
                Num -= decre;
            };
        }
    }
}
