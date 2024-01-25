#define TASK13

using System;

namespace Test
{
    class S1
    {
        private static void main(string[] args)
        {
#if TASK1
            float number = 0.01275f;
            Console.WriteLine($"number = {Math.Round(number, 2)}");
#elif TASK2
            Console.WriteLine($"e = {Math.Round(Math.E, 1)}");
#elif TASK3
            Console.Write("Enter any number: ");
            float number = float.Parse(Console.ReadLine().Replace('.', ','));
            Console.WriteLine($"You entered {number}");
#elif TASK4
            Console.Write("Enter any number: ");
            float number = float.Parse(Console.ReadLine().Replace('.', ','));
            Console.WriteLine($"{number} is a number you entered");
#elif TASK5
            Console.WriteLine("1 13 49");
#elif TASK6
            Console.WriteLine("7  15  100");
#elif TASK7
            float num1 = 2, num2 = 7, num3 = 6;
            Console.WriteLine($"{num1}  {num2}  {num3}");
#elif TASK8
            float num1 = 2, num2 = 7, num3 = 6, num4 = 12;
            Console.WriteLine($"{num1} {num2} {num3} {num4}");
#elif TASK9
            Console.WriteLine("50\n10");
#elif TASK10
            Console.WriteLine("5\n10\n21");
#elif TASK11
            float num1 = 0.2f, num2 = 7, num3 = 62.93f, num4 = 19;
            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}");\
#elif TASK12
            Console.WriteLine("5 10\n7 см");
#elif TASK13
            Console.WriteLine("2 кг\n13 17");
#endif
        }
    }
}
