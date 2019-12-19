using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int selector;
            Console.Write("Выберите задание(1-8): ");
            selector = int.Parse(Console.ReadLine());
            switch (selector)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Первая задача.\n");
                    first();
                    break;
                case 2:
                    Console.WriteLine("Вторая задача.\n");
                    second();
                    break;
                case 3:
                    Console.WriteLine("Третья задача.\n");
                    third();
                    break;
                case 4:
                    Console.WriteLine("Четвёртая задача.\n");
                    four();
                    break;
                case 5:
                    Console.WriteLine("Пятая задача.\n");
                    five();
                    break;
                case 6:
                    Console.WriteLine("Шестая задача.\n");
                    six();
                    break;
                case 7:
                    Console.WriteLine("Седьмая задача.\n");
                    seventh();
                    break;
                case 8:
                    Console.WriteLine("Восьмая задача.\n");
                    eight();
                    break;
                default:
                    break;
            }


        }

        static void first()
        {
            int lenghth, low = -30, high = 45;
            Console.Write("Сколько элементов будет в массиве? ");
            lenghth = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] array = new int[lenghth];

            for (int i = 0; i < lenghth; i++)
            {
                array[i] = rand.Next(low, high);
            }

            int counter = 0;
            for (int i = 0; i < lenghth; i++)
            {
                Console.Write($"{array[i]} ");
                counter++;
                if (counter % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.Write("\n\n\n");

            int reverser = 0;
            int[] reversed = new int[lenghth];
            for (int i = lenghth - 1; i > -1; i--)
            {
                reversed[i] = array[reverser];
                reverser++;
            }

            int counter2 = 0;
            for (int i = 0; i < lenghth; i++)
            {
                if (reversed[i] < 0) continue;
                Console.Write($"{reversed[i]} ");
                counter2++;
                if (counter2 % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
        }

        static void second()//не выполенено требование про не использование доп.массива
        {
            int[,] duo = { { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 } };
            int rows = 7, columns = 7;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{duo[i, j]} ");
                }
                Console.Write("\n");
            }

            int[,] rotate = new int[7, 7];
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rotate[i, j] = duo[j, i];

                    Console.Write($"{rotate[i, j]} ");
                }
                Console.Write("\n");
            }
        }

        static void third()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.Write("\nНа сколько позиций вы хотите сдвинуть массив? ");
            int k = int.Parse(Console.ReadLine());

            if (k > array.Length)
            {
                k = k % array.Length;
            }

            int[] changed = array.ToArray();
            int counter = 0;
            for (int i = 0; i < changed.Length; i++)
            {

                if (i + k >= changed.Length)
                {
                    changed[i] = array[counter];
                    counter++;
                    continue;
                }
                changed[i] = array[i + k];
            }

            for (int i = 0; i < changed.Length; i++)
            {
                Console.Write($"{changed[i]} ");
            }
        }

        static int[,] plus(int[,] a, int[,] b)
        {
            int[,] result = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            double temp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp += result[i, j];
                }
            }
            Console.WriteLine($"Среднее значение элементов: {temp / 9}");
            return result;

        }
        static int[,] minus(int[,] a, int[,] b)
        {
            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }

            double temp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp += result[i, j];
                }
            }
            Console.WriteLine($"Среднее значение элементов: {temp / 9}");
            return result;
        }

        static void four()
        {
            int low = 1, high = 9;
            Random rand = new Random();
            int[,] a = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = rand.Next(low, high);
                }
            }

            int[,] b = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    b[i, j] = rand.Next(low, high);
                }
            }

            Console.WriteLine("Массив a: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Массив b: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{b[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Выберите действие с массивами (1 - сложение или 2 - вычитание)");
            int selector = int.Parse(Console.ReadLine());
            int[,] result;
            switch (selector)
            {

                case 1:
                    result = plus(a, b);
                    Console.WriteLine("Результирующий массив: ");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"{result[i, j]} ");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 2:
                    result = minus(a, b);
                    Console.WriteLine("Результирующий массив: ");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write($"{result[i, j]} ");
                        }
                        Console.Write("\n");
                    }
                    break;
                default:
                    break;

            }
        }

        static void five()
        {
            int low = 1, high = 9;
            Random rand = new Random();
            int[,] a = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = rand.Next(low, high);
                }
            }

            int[,] b = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    b[i, j] = rand.Next(low, high);
                }
            }

            Console.WriteLine("Массив a: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Массив b: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{b[i, j]} ");
                }
                Console.Write("\n");
            }

            int[,] result = new int[5, 5];
            Console.WriteLine("Результирующий массив: ");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                    Console.Write($"{result[i, j]} ");
                }
                Console.Write("\n");
            }
        }



        //6-е задание
        public static int sum = 0;
        public static int sumIterative(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public static int sumRecursive(int[] b, int iterator)
        {
            if (iterator < b.Length)
            {
                sum += b[iterator];
                iterator++;
                sumRecursive(b, iterator);
            }
            return sum;
        }
        public static int minIterative(int[] c)
        {
            int min = c[0];
            for (int i = 0; i < c.Length; i++)
            {
                if (min > c[i])
                {
                    min = c[i];
                }
            }
            return min;
        }
        public static int minRecursive(int[] d, int counter, int minValue)
        {
            if (counter == d.Length)
            {
                return minValue;
            }
            else
            {
                minValue = Math.Min(minValue, d[counter]);
                counter++;
                return minRecursive(d, counter, minValue);
            }

        }

        static void six()
        {
            int iterator = 0;
            int[] arr = { 3, 5, 65, 3, 1, 12, 7, 9 };
            Console.Write("Введите функцию 1-4: ");
            int pointer = int.Parse(Console.ReadLine());
            switch (pointer) {
                case 1:
                    Console.WriteLine(sumIterative(arr));
                    break;
                case 2:
                    Console.WriteLine(sumRecursive(arr, iterator));
                    break;
                case 3:
                    Console.WriteLine(minIterative(arr));
                    break;
                case 4:
                    Console.WriteLine("Min element is: "+minRecursive(arr, 0, Int32.MaxValue));
                    Console.ReadKey();
                    break;
                default:
                    break;
            }

        }

        public static int fibonacci(int N,int one,int two,int sum)
        {
            if (N == 0) return 0;
            sum = one + two;
            Console.WriteLine(sum);
            return (fibonacci(N - 1, two, sum, sum));

        }

        static void seventh()
        {
            Console.Write("Введите N-ое число из ряда Фибоначчи: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int first = 1, second = 1;
            Console.WriteLine();
            Console.WriteLine("{0}  \n{1}", first, second);
            int sum = 0;
            fibonacci(N, first, second, sum);
        }

        static void eight()
        {
            int min = -99, max = 99, det = 0, minor = 0, alg_comp = 0; ;
            Random rand = new Random();
            Console.Write("Введите значение 'N' для матирцы NxN: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Матрица: ");
            int[,] matrix = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(min, max);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
