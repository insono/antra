using System;

namespace Exercise5
{
    class Program
    {
        class Box
        {
            double length = 0, height = 0, breadth = 0;
            public double getVolume()
            {
                return length * breadth * height;
            }
            public void setLength(double len)
            {
                length = len;
            }

            public void setBreadth(double bre)
            {
                breadth = bre;
            }

            public void setHeight(double hei)
            {
                height = hei;
            }

            public Box(double l, double b, double h)
            {
                this.setLength(l);
                this.setBreadth(b);
                this.setHeight(h);
            }
        }
        static void Main(string[] args)
        {
            Box A = new Box(3, 4, 5);
            Box B = new Box(10, 10, 10);
            Box C = new Box(30, 40, 50);
            Console.WriteLine($"Box A vol: {A.getVolume()}");
            Console.WriteLine($"Box B vol: {B.getVolume()}");
            Console.WriteLine($"Box C vol: {C.getVolume()}");

        }
    }
}
