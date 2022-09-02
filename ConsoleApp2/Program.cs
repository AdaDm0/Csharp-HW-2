using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ВЫПОЛНЕНО
            ЗАДАНИЕ 2. Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
            Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.*/


            //создание и заполнение массива
            int minNum;
            int maxNum;
            int sum = 0;
            int[,] b = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    b[j, i] = random.Next(-100, 100);
                }
            }
            //вывод массива
            Console.Write("b[,] = ");
            for (int i = 0; i < 5; i++)
            {
                if (i != 0)
                {
                    Console.Write("        ");
                }
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(b[j, i] + "  ");
                }
                Console.WriteLine();
            }

            int[] bb = new int[b.Length];     // перевод двумерного массива в одномерный
            bb = b.Cast<int>().ToArray();
            Console.WriteLine("bb [] =  ");
            for (int i = 0; i < bb.Length; i++)
            {
                Console.Write(bb[i] + "   ");
            }
            Console.WriteLine();

            
            //поиск индексов min / max значений
            minNum = Array.IndexOf(bb, bb.Min());
            maxNum = Array.IndexOf(bb, bb.Max());
            Console.WriteLine("min num = " + minNum + " , max num = " + maxNum);

            //подсчет суммы элементов в диапазоне
            if (minNum>maxNum)
            {
                int temp = minNum;
                minNum = maxNum;
                maxNum = temp;
            }
            for (int i =minNum+1;i<maxNum;i++)
            {
                sum+= bb[i];
            }
            Console.WriteLine("Сумма элементов между минимальным и максимальным значениями составляет " + sum);

        }
    }
}
