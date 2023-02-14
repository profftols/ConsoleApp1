using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class OverridesInteger
    {
        private int j;
        private int k;

        public int J
        {
            get { return j; }
        }
        public int K
        {
            get { return k; }
        }

        public OverridesInteger(int j, int k)
        {
            this.j = j;
            this.k = k;
        }

        public static bool operator ==(OverridesInteger o1, OverridesInteger o2)
        {
            return (o1.k == o2.k && o1.j == o2.j);
        }
        public static bool operator !=(OverridesInteger o1, OverridesInteger o2)
        {
            return (o1.k != o2.k || o1.j != o2.j);
        }
        public static bool operator <(OverridesInteger o1, OverridesInteger o2)
        {
            return (o1.j < o2.j && o1.k < o2.k);
        }
        public static bool operator >(OverridesInteger o1, OverridesInteger o2)
        {
            return (o1.k > o2.k && o1.j > o2.j);
        }
        public static bool operator <=(OverridesInteger o1, OverridesInteger o2)
        {
            return (o1.k <= o2.k && o1.j <= o2.j);
        }
        public static bool operator >=(OverridesInteger o1, OverridesInteger o2)
        {
            return (o1.k >= o2.k && o1.j >= o2.j);
        }

        public static OverridesInteger operator ++(OverridesInteger o)
        {
            o.k++;
            o.j++;
            return o;
        }
        public static OverridesInteger operator --(OverridesInteger o)
        {
            o.j--;
            o.k--;
            return o;
        }
        public static OverridesInteger operator +(OverridesInteger o1, OverridesInteger o2)
        {
            return new OverridesInteger (o1.k + o2.k, o1.j + o2.j);
        }
        public static OverridesInteger operator -(OverridesInteger o1, OverridesInteger o2)
        {
            return new OverridesInteger (o1.k - o2.k, o1.j - o2.j);
        }

        public double Calc(string x, double q, double w)
        {
            if (x == "*") return q * w;

            else if (x == "/") return q / w;

            else return q % w;
        }
        public int Calc(string x, int q, int w)
        {
            if (x == "*") return q * w;

            else if (x == "/") return q / w;

            else return q % w;
        }
        public float calc(string x, float q, float w)
        {
            if (x == "*") return q * w;

            else if (x == "/") return q / w;

            else return q % w;
        }
        public void Motrh(double f)
        {
            f.ToString();
            f += 5;
            Console.WriteLine(f);
        }
    }
}
