using System;

namespace ClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class MyFunctions
    {
        /// <summary>
        /// Возвращает строку вида 1,2,3,...,N
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetStringOfNumbers(int number)
        {
            if(number <= 0)
            {
                throw new ArgumentOutOfRangeException("Значение доложно быть положительным", nameof(number));
            }

            var outputString = "";

            for (var i = 1; i <= number; i++)
            {
                outputString += i.ToString();

                if (i != number)
                {
                    outputString += ',';
                }
            }
            return outputString;
        }

        /// <summary>
        /// Возвращает строку в виде квадрата из звездочек размера N
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public string GetRectangleAsterix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Размер квадрата должен быть положительным", nameof(size));
            }
            if (size%2 == 0)
            {
                throw new ArgumentOutOfRangeException("Размер квадрата должен быть нечётным", nameof(size));
            }

            var middle = (size - 1) / 2;

            var outputString = "";

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    outputString +=
                        ((i != middle) || (j != middle))
                            ? '*'
                            : ' '; 
                }
                outputString += '\n';                
            }
            return outputString;
        }
    }
}
