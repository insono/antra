using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    abstract class Shape1
    {

        protected float R, L, B;

        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();

        public static void Calculate(Shape1 S)
        {

            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());

        }
    }

    class Rectangle:Shape1
    {
        public Rectangle()
        {
            Console.WriteLine("Enter Length value: ");
            L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth value: ");
            B = Convert.ToInt32(Console.ReadLine());
        }

        public override float Area()
        {
            return L * B;
        }

        public override float Circumference()
        {
            return 2 * L + 2 * B;
        }
    }

    class Circle : Shape1
    {
        public Circle()
        {
            Console.WriteLine("Enter radius value: ");
            R = Convert.ToInt32(Console.ReadLine());
        }

        public override float Area()
        {
            return (float)Math.PI * R * R;
        }

        public override float Circumference()
        {
            return 2 * (float)Math.PI * R;
        }
    }
}


