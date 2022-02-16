using System;

namespace _06_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter1, letter2, counter;
            Console.Write("Enter the first letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());
            counter = Convert.ToInt32(letter1);
            do
            {
                Console.Write("Enter the second letter: ");
                letter2 = Convert.ToChar(Console.ReadLine());
            } while (Convert.ToInt32(letter1) > Convert.ToInt32(letter2));
            do
            {                              
                Console.WriteLine($"{Convert.ToChar(counter)} {counter}"); 
                counter++;
            }while (counter <= Convert.ToInt32(letter2));
        }
    }
}
