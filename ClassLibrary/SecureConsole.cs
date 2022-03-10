using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Функция безопасного ввода целого числа в консоль
    /// </summary>
    public class SecureConsole
    {
        /// <summary>
        /// Возвращает целое число введёное в консоль
        /// </summary>
        /// <returns></returns>
        public int SecureInputInteger()
        {
            string input = null;
            int number;

            while (true)
            {
                Console.WriteLine("Введите число!");

                input = Console.ReadLine();

                if (input == null)
                    Console.WriteLine("Введена пустая строка!");
                else
                {
                    bool isParsable = Int32.TryParse(input, out number);

                    if (isParsable)
                        return number;
                    else
                        Console.WriteLine("Введённая строка не явлвяется целым числом!");
                }
            }
        }
    }
}
