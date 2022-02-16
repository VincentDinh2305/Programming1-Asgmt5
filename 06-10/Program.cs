using System;

namespace _06_10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberInput = 10;
            int sum = 0;
            for (int counter = 0; counter < numberInput; counter++)
            {
                Console.Write($"Please enter grade of #{counter + 1}: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("An invalid grade has been entered");
                }
                else
                {
                    sum = sum + grade;
                    if (sum >= 999)
                    {
                        Console.WriteLine($"Total you grade is 999");
                    }
                    else
                    {
                        //Console.WriteLine($"Total you grade is {sum}");
                    }
                }               
            } 
            Console.WriteLine($"Total you grade is {sum}");
            /*Where is "grade 999" comes from? grade from 0 to 100, 
            is it correct? 
            the question is not clear to do so,
            If "total grade" is "999", it makes sense*/
        }
    }
}
