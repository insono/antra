using System;

namespace Exercise2
{
    class Program
    {
        public class Arithmetic
        {
            public int a, b;
            public int addition() { return a + b; }
            public int subtraction() { return a - b; }
            public int multiplication() { return a * b; }
            public int division() { return a / b; }
        }
        static void Main(string[] args)
        {
            Arithmetic math = new Arithmetic();
            Console.WriteLine("Enter first number: ");
            math.a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            math.b = Convert.ToInt32(Console.ReadLine());
            int option = 0;
            Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(math.addition());
                    break;
                case 2:
                    Console.WriteLine(math.subtraction());
                    break;
                case 3:
                    Console.WriteLine(math.multiplication());
                    break;
                case 4:
                    Console.WriteLine(math.division());
                    break;
            }
        }
    }
}
