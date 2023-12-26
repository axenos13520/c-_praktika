#define TASK3

using System;

namespace Test
{
    class S3
    {
        private static void Main(string[] args)
        {
#if TASK1
            float a = 1, b = 2, temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
#elif TASK2
            float a = 1, b = 2, c = 3, tempA = a, tempB = b;
            // a
            b = c;
            a = tempB;
            c = tempA;
            Console.WriteLine($"a) a = {a}, b = {b}, c = {c}");
            // b
            a = 1; b = 2; c = 3; tempA = a; float tempC = c;
            b = a;
            c = tempB;
            a = tempC;
            Console.WriteLine($"b) a = {a}, b = {b}, c = {c}");
#elif TASK3
            float a = 10, result, b, c;
            // a (a^4)
            b = a * a;
            result = b * b;
            // b (a^6)
            b = a * a;
            result = b * b * b;
            // c (a^7)
            b = a * a;
            result = b * b * b * a;
            // d (a^8)
            b = a * a;
            b *= b;
            result = b * b;
            // e (a^9)
            b = a * a;
            b *= b;
            result = b * b * a;
            // f (a^10)
            b = a * a;
            c = b * b;
            result = c * c * b;
#endif
        }
    }
}
