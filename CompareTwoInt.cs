using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int max;

            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }

            Console.WriteLine("The maximum of " + num1 + " and " + num2 + " is " + max);
           
        }
    }
}
