using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Narray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива.");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string (' ',20));
            Random rand = new Random();

            int[] array = new int[N];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }
            Console.WriteLine("Массив состоит из элементов :");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }

            Console.WriteLine(new string ('-',20));

            Console.WriteLine("Наибольшее значение массива - " + array.Max());
            Console.WriteLine("Наименьшее значение массива - " + array.Min());
            Console.WriteLine("Общая сумма всех элементов массива - " + array.Sum());
            Console.WriteLine("Среднее арифметическое значений массива - " + array.Sum()/array.Length);
            Console.WriteLine(new string(' ',20));
            Console.WriteLine("Нечетные значения элементов массива :");
            for (int h = 0; h < array.Length; h++)
            {
                if (array[h]%2 == 1)
                {
                    Console.WriteLine(array[h]);
                }
                
            }

        }
    }
}
