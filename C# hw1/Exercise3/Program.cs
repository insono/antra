using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to Reverse: ");
            string str;
            str = Console.ReadLine();
            string reversed = "";
            for (int i = str.Length-1; i >= 0; --i)
            {
                reversed += str[i];
            }

            Console.WriteLine("Reversed is: " + reversed);
        }
    }
}
