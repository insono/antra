using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Person
    {
        protected int Age;
        public void SetAge(int x) { Age = x; }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {Age}");
        }
        public void Hello()
        {
            Console.WriteLine("Hello.");
        }
    }
}
