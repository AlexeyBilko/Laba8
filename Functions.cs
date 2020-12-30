using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Functions
    {
        public int[,] Init()
        {
            int[,] array = new int[5, 5];
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(0, 10);
                }
            }
            return array;
        }

        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }

        public int[,] SecondArrayInit(int[,] array)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = findMax(array, i, j);
                }
            }
            return array;
        }

        public int findMax(int[,] array, int i, int j)
        {

            int max = 0;
            int k = 0;

            for (int a = i; a < 5; a++, k++)
            {
                for (int b = (j - k < 0 ? 0 : j - k); b <= (j + k > 4 ? 4 : j + k); b++)
                    if (array[a, b] > max)
                        max = array[a, b];
            }
            return max;
        }
    }
}
