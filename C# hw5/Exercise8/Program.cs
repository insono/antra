using System;

namespace Exercise8
{
    abstract class A
    {
        int x;
        public abstract void f(int n);
        private virtual void g(uint n)
        {
            x = n as int;
        }
        public string ToString()
        {
            return x.ToString();
        }

    }
}
