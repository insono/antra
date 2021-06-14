using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Shape1.Calculate(rec);
            Circle cir = new Circle();
            Shape1.Calculate(cir);
        }
    }
}
