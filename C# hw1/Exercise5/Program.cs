using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int binary = 1;
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write(binary);
                    if (binary == 1) { binary = 0; }
                    else if (binary == 0) { binary = 1; }
                }
                Console.Write("\n");
            }
        }
    }
}
