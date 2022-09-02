using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Модуль 2. Задание 1.
             Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
            Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами 
            с помощью циклов. 
            Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы. 
            Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, 
            общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В*/

            double [] a = new double[5];
            double [,] b = new double[4, 3];

            //инициализация массивов: одномерного и двумерного
            for (int i = 0; i<a.Length; i++)
            {
                Console.Write("a[" + i + "] = ");
                a[i] = double.Parse(Console.ReadLine());
            }

            Random random = new Random();
            for (int i = 0; i<3; i++)
            {
                for (int j= 0; j < 4; j++)
                {
                    b[j, i] = Math.Round((random.NextDouble() * 100), 1);
                }
            }

            a[0] = 1.1;
            b[0, 0] = 1.1;
            a[1] = 1.5;
            b[1, 0] = 1.5;

            Console.Write("\n\n\nВЫВОД ЗНАЧЕНИЙ:\n" + "a[] = ");

           for (int i = 0; i<a.Length; i++)
            {
                Console.Write(a[i] + "   ");
            }

            Console.Write("\n\n b[,] = ");
            for (int i = 0; i < 3; i++)
            {
                if (i!=0)
                {
                    Console.Write("        ");
                }
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(b[j, i] + "  ");
                }
                Console.WriteLine();
            }

            
            double sum;
            double multy;
            double sumEven; //четных
            double sumOdd;  //нечетных


            double[] bb = new double[b.Length];     // перевод двумерного массива в одномерный
            bb = b.Cast<double>().ToArray();
            Console.WriteLine("bb [] =  ");
            for (int i = 0; i < bb.Length; i++)
            {
                Console.Write(bb[i] + "   ");
            }
            Console.WriteLine();

            //Найти в данных массивах общий максимальный элемент, минимальный элемент - НЕ ДОДЕЛАНО
            //int count =-1;
            //for (int i = 0; i<a.Length; i++)
            //{
            //    for (int y = 0; y<b.Length; y++)
            //    {
            //        if (a[i]==bb[y])
            //        {
            //            bb[++count]+= a[i];
            //        }
            //    }
            //}
            //for (int i = 0; i<bb.Length; i++) 
            //{
            //    Console.WriteLine("bb[" + i + "] = ");
            //}


            //Найти общую сумму всех элементов
            sum = a.Sum()+bb.Sum();
            Console.WriteLine("sum = " + sum);
            //sum = bb.Sum();
            Console.WriteLine("sum = " + sum);




            //Array.Sort(a);
            //Array.Sort(bb);

            //ВАРИАНТ 1. не добавляет последующие повторные элементы
            //double []commonArr = new double[a.Length];
            //int n = 0;
            //for (int i = 0; i<a.Length; i++)
            //{
            //    for (int y = 0;y<bb.Length;y++)
            //    {
            //        if (a[i] == bb[y])
            //        {
            //            //commonArr.Append(a[i]);
            //            commonArr[n] = a[i];
            //            n++;
            //        }
            //    }
            //}
            //Console.WriteLine("\n\n commonArr[] = ");
            //for (int i = 0; i < commonArr.Length; i++)
            //{
            //    Console.Write(commonArr[i] + "   ");
            //}
            //if (commonArr.Any())
            //{
            //    Console.WriteLine("commonMin = " + Convert.ToString(commonArr.Min()));
            //    Console.WriteLine("commonMax = " + Convert.ToString(commonArr.Max()));
            //}


            //ВАРИАНТ №2 РЕШЕНИЯ MIN/MAX (Intersect работает только на первые элементы массива?!)
            // создание массива чисел, общих для двух массивов. Если массив не пустой, вывести min и  max
            //double[] commonArr = a.Intersect(bb).ToArray();
            //Console.WriteLine("\n\n commonArr[] = ");
            //for (int i = 0; i < commonArr.Length; i++)
            //{
            //    Console.Write(commonArr[i] + "   ");
            //}

            //if (commonArr.Any())
            //{
            //    Console.WriteLine("commonMin = " + Convert.ToString(commonArr.Min()));
            //    Console.WriteLine("commonMax = " + Convert.ToString(commonArr.Max()));
            //}
            //else
            //{
            //    Console.WriteLine("No common numbers");
            //}





        }
    }
}
