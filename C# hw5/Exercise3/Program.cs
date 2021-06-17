using System;

class Mainclass
{
    static  void f(string s)
              {
        s += "world";
    }
    static void Main (string[] args)
    {
        string s = "Hello";
        f(s);
        Console.WriteLine(s);
    }
}
