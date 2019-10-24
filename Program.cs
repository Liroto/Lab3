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
                    break;
                case 7:
                    Console.WriteLine("Седьмая задача.\n");
                    break;
                case 8:
                    Console.WriteLine("Восьмая задача.\n");
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
            for (int i = lenghth-1; i > -1; i--)
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

            int[,] rotate = new int [7,7];
            Console.WriteLine();
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
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

            if (k > array.Length) {
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
            int[,] result = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = a[i,j] + b[i,j];
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
            Console.WriteLine($"Среднее значение элементов: {temp/9}");
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
            int rowa_counter = 0, columna_counter = 0, rowb_counter = 0, columnb_counter = 0, help_counter = 0, temp = 0, n = 0;
            Console.WriteLine("Результирующий массив: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {   
                    temp = 0;
                    do
                    {   
                        result[i, j] += a[rowa_counter, j] * b[i, columnb_counter];
                        temp = result[i, j];
                        columnb_counter++;
                        rowa_counter++;
                    }
                    while (columnb_counter < 5 || rowa_counter < 5);
                    switch (help_counter)
                    {
                        case 0:
                            rowb_counter = 1;
                            columna_counter = 1;
                            columnb_counter = 0;
                            rowa_counter = 0;
                            help_counter++;
                            break;
                        case 1:
                            rowb_counter = 2;
                            columna_counter = 2;
                            columnb_counter = 0;
                            rowa_counter = 0;
                            help_counter++;
                            break;
                        case 2:
                            rowb_counter = 3;
                            columna_counter = 3;
                            columnb_counter = 0;
                            rowa_counter = 0;
                            help_counter++;
                            break;
                        case 3:
                            rowb_counter = 4;
                            columna_counter = 4;
                            columnb_counter = 0;
                            rowa_counter = 0;
                            help_counter++;
                            break;
                        default:
                            rowa_counter = 0;
                            rowb_counter = 0;
                            columna_counter = 0;
                            columnb_counter = 0;
                            help_counter = 0;
                            break;
                    }
                    Console.Write($"{result[i, j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}
