using System;

namespace Factorial
{
    class FactorialNumber
    {
        private static Int32 Cycle(Int32 n)
        {
            Int32 res = n;
            for (int i = n - 1; i != 0; i--)
            {
                if (Int32.MaxValue / i < res)
                {
                    throw new ArgumentOutOfRangeException($"Число слишком большое для подсчета факториала!");
                }
                res *= i;
            }
            return res;
        }

        private static Int32 Recursion(Int32 n)
        {
            return (n != 1) ? n * Recursion(n - 1) : 1;
        }

        public static void DoCycle()
        {
            String enter;
            Int32 num;
            Console.WriteLine("Введите число для вычисления факториала циклически : ");
            enter = Console.ReadLine();
            // ReSharper disable once PossibleNullReferenceException
            enter = enter.Trim().Replace(" ", "").Replace("\t","");
            num = Int32.Parse(enter);
            if (num < 0)
            {
                throw new ArgumentException("Число не может быть меньше нуля!");
            }
            Console.WriteLine(Cycle(num));
        }

        public static void DoRecursion()
        {
            String enter;
            Int32 num;
            Console.WriteLine("Введите число для вычисления факториала рекурсивно : ");
            enter = Console.ReadLine();
            // ReSharper disable once PossibleNullReferenceException
            enter = enter.Trim().Replace(" ", "").Replace("\t", "");
            num = Int32.Parse(enter);
            if (num < 0)
            {
                throw new ArgumentException("Число не может быть меньше нуля!");
            }
            Console.WriteLine(Recursion(num));
        }
    }
}
