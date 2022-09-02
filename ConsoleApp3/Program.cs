using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ЗАДАНИЕ 3. Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. 
            Из Википедии: Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется символом, находящимся на некотором постоянном числе 
            позиций левее или правее него в алфавите. Например, в шифре со сдвигом вправо на 3, A была бы заменена на D, B станет E, и так далее. Подробнее тут: https://en.wikipedia.org/wiki/Caesarcipher.
            Кроме механизма шифровки, реализуйте механизм расшифрования.*/

            int key = 1;
            string word1;

            Console.WriteLine("Введите слово:   ");
            word1 = Console.ReadLine();

            string encryption (string word)
            {
                
                for (int i = 0; i<word.Length;i++)
                {
                    word.Replace(word[i], Convert.ToChar(Convert.ToInt32(word[i]) + key));
                }
                Console.WriteLine("Результат зашифровки: " + word);
                return word;
            }

            string decoding(string word)
            {

                for (int i = word.Length-1; i >=0; i--)
                {
                    word.Replace(word[i], Convert.ToChar(Convert.ToInt32(word[i]) - key));
                }
                Console.WriteLine("Результат расшифровки: " + word);
                return word;
            }

            word1 = encryption(word1);
            word1 = decoding(word1);

        }
    }
}
