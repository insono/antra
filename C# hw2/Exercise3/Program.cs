using System;

namespace Exercise3
{
    class Program
    {
        class Solution
        {
            public int TheSolution(int A, int B)
            {
                int counter = 0;
                for (int i = A; i <= B; ++i)
                {
                    if (Math.Sqrt(i) % 1 == 0)
                        ++counter;
                }

                return counter;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine($"Checking\nNumber is 9, sqrt is: {Math.Sqrt(9)}, is whole number? {(Math.Sqrt(9) % 1) == 0}");
            //Console.WriteLine($"Checking\nNumber is 10, sqrt is: {Math.Sqrt(10)}, is whole number ? {(Math.Sqrt(10) % 1) == 0}");
            int A, B;
            Console.WriteLine("Enter two values: ");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            int result = new Solution().TheSolution(A, B);
            Console.WriteLine("There are " +result+ " perfect squares");
        }
    }
}
