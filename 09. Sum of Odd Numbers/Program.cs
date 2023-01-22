using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <= num; i++)
            {


                Console.WriteLine(i * 2 - 1);
                total += i * 2 -1;

            }
            Console.WriteLine($"Sum: {total}");
        }
    }
}
