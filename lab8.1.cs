using System;

namespace lab8._1
{
    class Program
    {
        static double F(double x)
        {
            double s;
            double d;

            if (x > 3)
            {
                s = 0;

                for (int i = 1; i < 18;i+=2)
                {

                    
                    s = s + Math.Pow(Math.Sin(x), i);
                    
                }
                return s;
            }
            else
            {
                s = 15;
                d = Math.Tan(x);
                for (int i = 0; i < 5; i++)
                {
                    s = s + d;
                    d = Math.Tan(d);
                }
                return s;

            }
            
            
        }
        static double Max(double a, double b)
        {
            double m = a;
            if (b > m)
            {
                m = b;
            }
            return m;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            double u = Max(F(a), F(b));
            Console.WriteLine("u=", u);
        }
    }
}
