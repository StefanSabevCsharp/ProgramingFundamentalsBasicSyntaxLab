using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    return;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }

            }
        }
    }
}
