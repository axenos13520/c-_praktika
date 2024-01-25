#define TASK14A

using System;

namespace Test
{
    class S2_Part1
    {
        private static void main(string[] args)
        {
#if TASK1
            // a
            float x = 7;
            Console.WriteLine($"y = {7*x*x+3*x+6}");
            // b
            float a = 5;
            Console.WriteLine($"x = {12*a*a+7*a+12}");
#elif TASK2
            float a = 4;
            Console.WriteLine($"P = {a*4}");
#elif TASK3
            float r = 6;
            Console.WriteLine($"d = {r*2}");
#elif TASK5
            float a = 3;
            Console.WriteLine($"V = {a*a*a}\nS = {a*a*6}");
#elif TASK6
            float r = 3;
            Console.WriteLine($"l = {2*Math.PI*r}\nS = {Math.PI*r*r}");
#elif TASK7
            int num1 = 7, num2 = 5;
            Console.WriteLine($"Average arith = {(num1 + num2) / 2f}\nAverage geom = {Math.Pow(num1*num2, 0.5f)}");
#elif TASK8
            float v = 5.4f, m = 10.8f;
            Console.WriteLine($"p = {m / v}");
#elif TASK9
            float s = 10000f;
            int n = 1000000;
            Console.WriteLine($"p = {n / s}");
#elif TASK10
            float a = 7, b = 8;

            if (a == 0)
                throw new Exception("Incorrect \"A\" value!!!");

            Console.WriteLine($"x = {-b/a}");
#elif TASK11
            float a = 3, b = 4;
            Console.WriteLine($"c = {Math.Sqrt(a*a+b*b)}");
#elif TASK12
            float r = 3, R = 7;
            Console.WriteLine($"S = {Math.PI*R*R-Math.PI*r*r}");
#elif TASK13
            float a = 3, b = 4;
            Console.WriteLine($"P = {a+b+Math.Sqrt(a*a+b*b)}");
#elif TASK13A
            float num1 = 7, num2 = 5;
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
            Console.WriteLine($"Average arith = {(num1 + num2) / 2f}\nAverage geom = {Math.Pow(num1 * num2, 0.5f)}");
#elif TASK14
            float a = 5, b = 3, h = 2;
            Console.WriteLine($"P = {Math.Sqrt(Math.Pow((a-b)/2, 2)+h*h)*2+a+b}");
#elif TASK14A
            float a = 3, b = 4;
            Console.WriteLine($"P = {(a+b)*2}\nd = {Math.Sqrt(a*a+b*b)}");
#endif
        }
    }
}
