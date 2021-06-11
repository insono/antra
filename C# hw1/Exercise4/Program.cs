using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first number ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            b = Convert.ToInt32(Console.ReadLine());

            for(int i = a; i < b; ++i)
            {
                int ones = i % 10;
                int tens = i / 10;
                tens = tens % 10;
                int hundreds = i / 100;
                if (i == ones*ones*ones + tens*tens*tens + hundreds*hundreds*hundreds)
                {
                    Console.WriteLine(i);
                }
             }
        }
    }
}
