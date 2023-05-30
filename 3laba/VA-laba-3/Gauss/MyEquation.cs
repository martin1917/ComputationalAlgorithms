using System;
using System.Collections.Generic;

namespace VA_laba_3.Gauss
{
    public class MyEquation
    {
        private List<double> Equation { get; } = new List<double>();

        public int Size => Equation.Count;

        public void Generate(int size, int a, int b)
        {
            if (size < 2) size = 2;
            Equation.Clear();
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                // Equation.Add(a + rnd.NextDouble() * (b-a + 1));
                Equation.Add((double)rnd.Next(a, b) + 1);
            }
        }

        public void AddEquation(MyEquation item)
        {
            for (int i = 0, j = 0; i < Equation.Count && j < item.Equation.Count; i++, j++)
            {
                Equation[i] += item.Equation[j];
            }
        }

        public void Mul(double coefficient)
        {
            for (int i = 0; i < Equation.Count; i++)
            {
                Equation[i] *= coefficient;
            }
        }

        public double FindCoefficient(double a, double b)
        {
            if (a == 0.0) return 1.0;
            return -b / a;
        }

        public double Get(int index)
        {
            return Equation[index];
        }

        public void SetValue(int index, double val)
        {
            Equation[index] = val;
        }
    }
}
