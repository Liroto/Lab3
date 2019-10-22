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
                    break;
                case 5:
                    Console.WriteLine("Пятая задача.\n");
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
                k = k % array.Length; //3
            }

            int[] changed = array.ToArray();
            int counter = 0;
            for (int i = 0; i < changed.Length; i++) //c.L = 9
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
    }
}
