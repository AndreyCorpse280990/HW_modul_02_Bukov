using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_02_Bukov
{
    internal class Program
    {
        private static void Task1()
        {
            /* ЗАДАНИЕ 1
            Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
            Заполнить одномерный массив А числами, введенными с клавиатуры пользователем,
            а двумерный массив В случайными числами с помощью
            циклов. Вывести на экран значения массивов: массива
            А в одну строку, массива В — в виде матрицы. Найти в
            данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
            произведение всех элементов, сумму четных элементов
            массива А, сумму нечетных столбцов массива В.
             */
            double[] A = new double[5];
            double[,] B = new double[3, 5];

            Console.WriteLine($"Введите {A.Length} чисел ");
            for (int i = 0; i < 5; i++)
            {
                double input = Convert.ToDouble(Console.ReadLine());
                A[i] = input;
            }

            Random random = new Random();
            // Заполнение массива B случайными числами от 0 до 9
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.NextDouble() * 9 + 1; // Случайное число от 0 до 9
                }
            }

            double maxA = A[0]; // масимальное число массива А
            double minA = A[0]; // минимальное число массива А
            double sumA = 0; // сумма чисел А
            double productOfNumbersA = 1; // произведение чисел А
            double sumEvenNumbersA = 0; // сумму четных элементов

            // наъождение максимального элемента массива А
            for (int i = 1; i < A.Length; i++)
            {
                if (maxA < A[i]) // максимум
                {
                    maxA = A[i];
                }

                if (minA > A[i])// минимум
                {
                    minA = A[i];
                }
                sumA += A[i]; // сумма
                productOfNumbersA *= A[i]; //произведение

                if (A[i] % 2 == 0) // четные числа массива А
                {
                    sumEvenNumbersA += A[i];
                }

            }


            Console.WriteLine("Массив А:");
            Console.WriteLine($"{string.Join(", ", A)}\n"); // вывод массива А
            Console.WriteLine($"Max A {maxA}");
            Console.WriteLine($"Min A {minA}");
            Console.WriteLine($"Sum A {sumA}");
            Console.WriteLine($"Произведение А {productOfNumbersA}");
            Console.WriteLine($"Сумма четных чисел массива А {sumEvenNumbersA}");

            // нахождение максимального элементамассива В
            double maxB = B[0, 0]; // максимальное число массива В
            double minB = B[0, 0]; // минимальное число массива В
            double sumB = 0; // сумма чисел массива В
            double productOfNumbersB = B[0, 0]; // произведение
            double sumOfOddColumns = 0; // сумма нечетных столбцов

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > maxB) //максимум
                    {
                        maxB = B[i, j];
                    }

                    if (B[i, j] < minB)//минимум
                    {
                        minB = B[i, j];
                    }
                    sumB += B[i, j]; // сумма
                    productOfNumbersB *= B[i, j]; // произведение
                }
            }
            for (int j = 0; j < B.GetLength(1); j++) // проход по каждому столбцу
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < B.GetLength(0); i++) // проход по строкам столбца
                    {
                        sumOfOddColumns += B[i, j]; // добавляем элемент столбца в сумму
                    }
                }
            }

            Console.WriteLine("\nМассив В:");
            for (int i = 0; i < B.GetLength(0); i++) // Вывод массива B 
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\n\nMax B {maxB}");
            Console.WriteLine($"min B {minB}");
            Console.WriteLine($"Sum B {sumB}");
            Console.WriteLine($"произведение В {productOfNumbersB}");
            Console.WriteLine($"Сумма нечетных столбцов массива B: {sumOfOddColumns}");
        }

        private static void Task2()
        {
            /*ЗАДАНИЕ 2
             * Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
            Определить сумму элементов массива, расположенных
            между минимальным и максимальным элементами.*/
            {
                int[,] arrayTask2 = new int[5, 5];
                Random random = new Random();
                int sumArrayTask2 = 0;
                int minArrayTask2 = int.MaxValue;
                int maxArrayTask2 = int.MinValue;
                int rowMin = 0, colMin = 0, rowMax = 0, colMax = 0;

                // Заполнение массива случайными значениями от -100 до 100
                for (int i = 0; i < arrayTask2.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayTask2.GetLength(1); j++)
                    {
                        arrayTask2[i, j] = random.Next(-100, 101);
                        if (arrayTask2[i, j] > maxArrayTask2)
                        {
                            maxArrayTask2 = arrayTask2[i, j];
                            rowMax = i;
                            colMax = j;
                        }
                        if (arrayTask2[i, j] < minArrayTask2)
                        {
                            minArrayTask2 = arrayTask2[i, j];
                            rowMin = i;
                            colMin = j;
                        }
                    }
                }

                // Вывод массива arrayTask2
                for (int i = 0; i < arrayTask2.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayTask2.GetLength(1); j++)
                    {
                        Console.Write(arrayTask2[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                // Определение суммы элементов между минимальным и максимальным элементами
                int startRow = Math.Min(rowMin, rowMax) + 1;
                int endRow = Math.Max(rowMin, rowMax);
                int startCol = Math.Min(colMin, colMax);
                int endCol = Math.Max(colMin, colMax);
                for (int i = startRow; i < endRow; i++)
                {
                    for (int j = startCol; j <= endCol; j++)
                    {
                        sumArrayTask2 += arrayTask2[i, j];
                    }
                }

                Console.WriteLine($"\nСумма элементов массива между минимальным ({minArrayTask2}) и максимальным ({maxArrayTask2}) элементами: {sumArrayTask2}");
            }
        }


        public static void Task3()
        {
            /*ЗАДАНИЕ 3
             * Создайте приложение, которое производит операции над матрицами:
            ■ Умножение матрицы на число;
            ■ Сложение матриц;
            ■ Произведение матриц.*/

            int[,] matrix1Task3 = new int[5, 5];
            int[,] matrix2Task3 = new int[5, 5];
            int[,] sumMatrix = new int[5, 5];
            int[,] multiplicationMatrix = new int[5, 5];
            int scalar = 5;
            Random random = new Random();

            // Заполнение матрицы случайными числами
            void fillingMatrix(ref int[,] matrix, Random rnd)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = random.Next(1, 10); 
                    }
                }
            }


            // Вывод матрицы
            void printMatrix(int[,] matrix)
            { 
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            // Умножение матрицы на число
            void Multiply(int[,] matrix, int scalarValue)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] *= scalarValue;
                    }
                }
            }

            // сложение матриц
            void Addition(int[,] matrix1, int[,] matrix2, int[,] matrix3)
            {
                for(int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
            }

            //произведение матриц
            void Multiplication(int[,] matrix1, int[,] matrix2, int[,] matrix3)
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        matrix3[i, j] = matrix1[i, j] * matrix2[i, j];
                    }
                }
            }

            // Заполнение матрицы1 случайными числами
            fillingMatrix(ref matrix1Task3, random);
            Console.WriteLine("Изначальная матрица1");
            printMatrix(matrix1Task3);

            // Заполнение матрицы2 случайными числами
            fillingMatrix(ref matrix2Task3, random);
            Console.WriteLine("\nИзначальная матрица2");
            printMatrix(matrix2Task3);

            Multiply(matrix1Task3, scalar); // Умножение матрицы на число
            Console.WriteLine($"\nРезультат после умножения матрицы1 на число {scalar}");
            printMatrix(matrix1Task3);



            Addition(matrix1Task3, matrix2Task3, sumMatrix); // сложение матриц
            Console.WriteLine("\nМатрица после сложения двух матриц");
            printMatrix(sumMatrix);

            Multiplication(matrix1Task3, matrix2Task3, multiplicationMatrix);
            Console.WriteLine("\nМатрица после умножения двух матриц");
            printMatrix(multiplicationMatrix);

        }
        static void Main(string[] args)
        {
            
            Task3();
        }
    }

}