using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задание 5. Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать его результат. 
             *Необходимо поддерживать только две операции: + и –.*/

            //Console.WriteLine("Введите арифметическое выражение");
            //string str = Console.ReadLine();

            string str= "2 + 3";

            if (str.Contains(" "))
            {
                str = str.Replace(" ", "");
            }
            char[] arr = str.ToCharArray();
            char a;
            int b;
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsDigit(arr[i]) && (arr[i]=="+" | arr[i]=="-")) 
                {
                    b = i;
                }
            }



            //Console.WriteLine(str);
        }
    }
}
