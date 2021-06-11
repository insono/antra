using System;

namespace Exercise2
{
    class Program
    {
        public int Solution(int[] A)
        {
            Array.Sort(A);
            int currValue = 0;
            int currCounter = -1;
            int maxValue = 0;
            int maxCount = -1;
            for(int i = 0; i < A.Length; ++i)
            {
                if (currValue == A[i])
                    ++currCounter;
                else
                {
                    currCounter = 0;
                    currValue = A[i];
                }

                if(currCounter > maxCount)
                {
                    maxCount = currCounter;
                    maxValue = A[i];
                }
            }
            return maxValue;
        }

        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter array size: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter array values");
            for (int i = 0; i < size; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            var sol = new Program();
            Console.WriteLine("Most often value is: " + sol.Solution(arr));
        }
    }
}
