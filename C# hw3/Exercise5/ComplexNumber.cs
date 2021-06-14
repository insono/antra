using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class ComplexNumber
    {
        private int real, imaginary;
        public ComplexNumber(int r, int i)
        {
            real = r;
            imaginary = i;
        }

        public void SetReal(int r)
        {
            real = r;
        }
        public int GetReal() { return real; }

        public void SetImaginary(int i)
        {
            imaginary = i;
        }
        public int GetImaginary()
        {
            return imaginary;
        }
        public int GetMagnitude()
        {
            return real * real + imaginary * imaginary;
        }
        public void Add(ComplexNumber a)
        {
            this.SetReal(GetReal() + a.GetReal());
            this.SetImaginary(GetImaginary() + a.GetImaginary());
            return;
        }

        public override string ToString()
        {
            string result = $"({real},{imaginary})";
            return result;
        }
    }
}
