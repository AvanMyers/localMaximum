using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrrayLangth = 30;
            int minRandom = 0;
            int maxRandom = 100;
            string localMax = "";
            Random random = new Random();
            int[] array = new int[arrrayLangth];

            Console.Write("[ ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] += random.Next(minRandom, maxRandom);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("]");

            for(int i = 0; i < array.Length; i++)
            {
                if (i == 0) 
                {
                    if (array[0] < array[1])
                    {
                        localMax += Convert.ToString(array[i] + " ");
                    }
                } 
                else if (i == arrrayLangth - 1)
                {
                    if (array[i] < array[i - 1])
                    {
                        localMax += Convert.ToString(array[i]);
                    }
                } 
                else if (array[i] < array[i - 1] && array[i] < array[i + 1])
                {
                    localMax += Convert.ToString(array[i] + " ");
                }
            }

            Console.WriteLine($"Локальных максимумов в массиве {localMax}");
            Console.ReadKey();
        }
    }
}
