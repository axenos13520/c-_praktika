#define TASK28

using System;

namespace Test
{
    class S2_Part2
    {
        private static void main(string[] args)
        {
#if TASK15
            float num1 = 3, num2 = 4;
            Console.WriteLine($"Сумма - {num1+num2}\nРазность - {num1-num2}\nЧастное - {num1/num2}");
#elif TASK16
            float a = 3, b = 4;
            Console.WriteLine($"Объем - {a*b*a}\nПлощадь бок поверхности - {a*a}");
#elif TASK17
            float x1 = 3, y1 = 2, x2 = 0, y2 = 0;
            Console.WriteLine($"Расстояние - {Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2))}");
#elif TASK18
            
#elif TASK19
            float a = 4, b = 2, angle = 60; //deg
            Console.WriteLine($"Площадь трапеции - {Math.Tan(angle*Math.PI/180)*((a-b)/2)*((a-b)/2)+b*Math.Tan(angle*Math.PI/180)*((a-b)/2)}");
#elif TASK20
            float x1 = 0, y1 = 0, x2 = 2, y2 = 0, x3 = 1, y3 = 2;
            float dist1 = (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            float dist2 = (float)Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            float dist3 = (float)Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            float p = (dist1 + dist2 + dist3) / 2;
            Console.WriteLine($"Периметр треугольника - {p*2}\nПлощадь - {Math.Sqrt(p*(p-dist1)*(p-dist2)*(p-dist3))}");
#elif TASK21
            float x1 = 0, y1 = 0, x2 = 2, y2 = 0, x3 = 2, y3 = 2, x4 = 0, y4 = 2;
            float a = (float)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            float b = (float)Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            float c = (float)Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            float d = (float)Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
            float diag = (float)Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            float p1 = (a + b + diag) / 2;
            float p2 = (c + d + diag) / 2;
            Console.WriteLine($"Площадь четырехугольника - {Math.Sqrt(p1*(p1-a)*(p1-b)*(p1-diag))+Math.Sqrt(p2*(p2-c)*(p2-d)*(p2-diag))}");
#elif TASK22
            float appleCost = 2, appleMass = 3, cookieCost = 5, cookieMass = 0.7f, sweetsCost = 4, sweetsMass = 2;
            Console.WriteLine($"Общая стоимость - {appleCost*appleMass+cookieCost*cookieMass+sweetsCost*sweetsMass}");
#elif TASK23
            float screenCost = 1200, sysCost = 3000, keyboardCost = 500, mouseCost = 300, n=3;
            Console.WriteLine($"Общая стоимость - {(screenCost+sysCost+keyboardCost+mouseCost)*n}");
#elif TASK24
            float x = 23, y = 27;
            float average = (x + y) / 2;
            Console.WriteLine($"Средний возраст - {average}\nX - average = {x-average}\nY - average = {y-average}");
#elif TASK25
            float v1 = 40, v2 = 50, s = 130;
            Console.WriteLine($"Автомобили встретятся через {s/(v1+v2)} часов");
#elif TASK26
            float v1 = 60, v2 = 30, t = 0.5f;
            if (v1 < v2) throw new Exception("V1 must be bigger than V2!!!");
            Console.WriteLine($"Через {t} часов ({t*60} мин) первый автомобиль оторвется от второго на {(v1-v2)*t} км");
#elif TASK27
            float t = 233; // Celsium
            Console.WriteLine($"Фаренгейт - {t*1.8+32}\nКельвина - {t+273.15}");
#elif TASK28
            float t = 450; // Farengeit
            Console.WriteLine($"Цельсий - {(t-32)/1.8}");
#endif
        }
    }
}
