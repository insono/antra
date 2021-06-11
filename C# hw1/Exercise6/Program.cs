using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            string diamond = "";
            string botDiamond = "";
            for(int i = 0; i < rows; ++i)
            {
                string stars = "";
                for(int j = 0; j < 2*i+1; ++j)
                {
                    stars += "*";
                }
                string space = "";
                for (int j = 0; j < (2 * rows + 1 - stars.Length)/2; ++j)
                {
                    space += " ";
                }
                string row = space + stars + space;
                diamond += row + "\n";
                if (rows != i+1)
                botDiamond = row + "\n" + botDiamond;
            }
            Console.WriteLine(diamond + botDiamond);
        }
    }
}
