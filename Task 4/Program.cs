using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задание 4. Создайте приложение, которое производит операции над матрицами:
            ■ Умножение матрицы на число;
            ■ Сложение матриц;
            ■ Произведение матриц.*/

            int[,] arr1 = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { -1,0,-7} };
            int[,] arr2 = new int[3,3] { { 1, 1, 0 }, { 2, 1, 0 }, { 3, 1, 0 } };

            void print( int[,] arr)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(arr[i, j] + "  ");
                    }
                    Console.WriteLine("|");
                }
            }

            void multiplyOnNumber (int [,] arr, int num)
            {
                Console.WriteLine("УМНОЖЕНИЕ МАТРИЦЫ НА ЧИСЛО: ARR1 * " + num + " = ");
                print(arr);
                Console.WriteLine("\n* " + num + " = \n");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(arr[i, j] * num + "  ");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("\n\n");
            }

            void addition(int[,] array1, int[,] array2)
            {
                Console.WriteLine("СЛОЖЕНИЕ МАТРИЦ: ARR1 + ARR2 = ");
                print(array1);
                Console.WriteLine("+");
                print (array2);
                Console.WriteLine("=");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(array1[i, j] + array2[i,j] + "  ");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("\n\n");
            }

            void multyOnArray (int[,] array1, int[,] array2)
            {
                Console.WriteLine("УМНОЖЕНИЕ МАТРИЦ: ARR1 + ARR2 = ");
                print(array1);
                Console.WriteLine("*");
                print(array2);
                Console.WriteLine("=");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < 3; j++)
                    {
                        int res=0;
                        for (int k = 0; k < 3; k++)
                        {
                            res += array1[i, k] * array2[k, j];
                        }
                        Console.Write(res + " ");
                    }
                    Console.WriteLine("|");
                }
                Console.WriteLine("\n\n");
            }

            multiplyOnNumber(arr1, 2);
            addition(arr1, arr2);
            multyOnArray(arr1, arr2);




        }
    }
}
