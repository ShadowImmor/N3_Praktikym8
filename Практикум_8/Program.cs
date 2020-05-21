using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, word;
            bool prov = true;
            do
            {
                Console.Write("Введите осмысленный текст: ");
                str = Console.ReadLine();
                if (str.Length == 0)
                    Console.WriteLine("В строке должен быть хотя бы один символ");
            } while (str.Length == 0);
            do
            {
                Console.Write("Введите слово: ");
                word = Console.ReadLine();
                prov = true;
                if (Regex.IsMatch(word, @"[\W\s]+"))
                {
                    Console.WriteLine("Введите одно слово без знаков препинания и пробельных символов");
                    prov = false;
                }
                if (word.Length == 0)
                {
                    Console.WriteLine("В строке должен быть хотя бы один символ");
                    prov = false;
                }
            } while (!prov);
            Console.WriteLine("Заданная строка: " + str);
            Console.WriteLine("Заданное слово: " + word);
            Regex reg = new Regex(@"\b" + word + @"\b", RegexOptions.IgnoreCase);
            if (reg.IsMatch(str))
                Console.WriteLine("В заданное строке присутствует заданное слово");
            else
                Console.WriteLine("В заданное строке не присутствует заданное слово");
            Console.ReadLine();
        }
    }
}
