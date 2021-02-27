using System;
using System.ComponentModel;

namespace MiniMath
{
    public static class MiniMath
    {
        public static double Sqrt(double a)
        {
            if (a < 0) throw new Exception("Negative number");
            double ep = 0.001;
            double high = a, low = 0;
            double var = (high + low) / 2.0;
            while (Abs(Pow(var, 2) - a ) >= ep)
            {
                if (Pow(var, 2) < a)
                {
                    low = var;
                }
                else
                {
                    high = var;
                }

                var = (high + low) / 2.0;
            }

            return var;
        }
        
        public static double Root(double a, double b)
        {
            if (a < 0) throw new Exception("Negative number");
            double ep = 0.01;
            double n = b;
            double high = a, low = 0;
            double var = (high + low) / 2.0;
            while (Math.Abs(Math.Pow(var, n) - a) >= ep)
            {
                if (Math.Pow(var, n) < a)
                {
                    low = var;
                }
                else
                {
                    high = var;
                }

                var = (high + low) / 2.0;
            }

            return Math.Round(var,3);
        }
        
        public static double Pow(double a, double n)
        {
            double res = 1;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    a *= a;
                }
                else
                {
                    n--;
                    res *= a;
                }
            }
            return res;
        }
        
        public static double Abs(double a)
        {
            return a < 0 ? a = -a : a;
        }

        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            if (b == 0) throw new Exception("Divide by zero");
            return a / b;
        }

        public static double Factorial(int n)
        {
            if (n < 0) throw new Exception("Negative number");
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
        
        public static double Volume3d(double a, double b, double c)
        {
            return a * b * c;
        }

        public static double Perimeter(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
        
        public static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double AreaTriangle(double a,double b, double c)
        {
            double p = Perimeter(a,b,c) / 2.0;
            return Math.Round(Sqrt(p * (p - a) * (p - b) * (p - c)),2);
        }

        public static double GetPiRand(int IterationsPow)
        {
            double pi = 0;
            int count = 0,luck = 0;
            for (int i = 0; i < Pow(10,IterationsPow); i++) 
            {
                count++;
                Random rand = new Random();
                double x = rand.Next(-1000, 1000);
                double y = rand.Next(-1000, 1000);
                if (Sqrt(Pow(x, 2) + Pow(y, 2)) <= 1000)
                {
                    luck++;
                }
                pi = (double) (4 * luck) / (double) count;
            }

           return pi;
        }
        
        public static double GetPi()
        {
            double pi = 2;
            double d = 0;
            for (int i = 0; i < 10000000; i++) 
            {
                d = Sqrt(2 + d);
                pi = pi * 2.0/d;
            }

            return pi;
        }

        public static double GetE()
        {
            double e = 0;
            for (int i = 1; i < 1000; i++)
            {
                e = Pow((1 + 1 / (double) i),(double) i);
            }

            return e;
        }
    }
}