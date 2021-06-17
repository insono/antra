using System;

class A
{
    static int n = 1;
    public void f()
    {
        n++;
    }

    public void Report()
    {
        Console.WriteLine(n.ToString());
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        A x = new A(), Y = new A();
        x.f();
        x.Report();
        Y.f();
        Y.Report();
    }
}