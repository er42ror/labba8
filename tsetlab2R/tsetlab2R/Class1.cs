using System;
namespace labtest2
{

    public static class MyFunctions
    {
        // Функция сортировки массива целых чисел (пример: сортировка пузырьком)
        public static int[] SortIntArray(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array), "Массив не должен быть пустым");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        // Функция проверки строки на палиндром
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            input = input.ToLower();
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        // Функция вычисления факториала для целого числа
        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n), "Факториал не определен для отрицательных чисел");

            if (n == 0 || n == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Функция, возвращающая число Фибоначчи на указанной позиции
        public static int Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentOutOfRangeException(nameof(n), "Число Фибоначчи не определено для отрицательных чисел");

            if (n <= 1)
                return n;

            int a = 0;
            int b = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return result;
        }

        // Функция, возводящая число в степень
        public static double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        // Функция, проверяющая, является ли число простым
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}