using System;

namespace Steffens_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Re:
            Console.WriteLine("Enter the value of a and b: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double accuracy = 0.00000000000001;
          
            double x0;
            double x1;
            if (a < b && Function(a) * Function(b) < 0)
            {
                x0 = (a + b) / 2;

                while (true)
                {

                    double e =  x0 + Function(x0);
                    x1 = x0 -( (Function(x0) * Function(x0)) / (Function(e) - Function(x0)));
                    Console.WriteLine($"The value of x is {x1}");
                    if (Function(x1) == 0)
                    {
                        Console.WriteLine($"The exact root is X = {x1}");
                        return;
                    }
                    else if (Math.Abs(Function(x1)) <= accuracy)
                    {
                        Console.WriteLine($"The Root is X = {x1}");
                        return;
                    }
                    else
                    {
                        x0 = x1;
                    }

                }

            }
            
            else
            {
                goto Re;
            }

        }
        static double Function(double x)
        {
            return x * x * x - x - 1;
        }
    }
}
