using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 25;
            decimal c = .750m;
            decimal d = .125m;
            int e = 10;
            int f = 20;

            var answer1 = Add(a, b);
            var answer2 = Add(c, d);
            var answer3 = Add(e, f, true);

            Console.WriteLine($"Integer method: {answer1}\nDecimal method: {answer2}");
            Console.WriteLine(answer3);

        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool check)
        {
            int sum = x + y;
            if(check == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(check == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(check == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

    }
}
