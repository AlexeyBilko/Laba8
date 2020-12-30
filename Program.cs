using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] FirstArray = Init();
            PrintArray(FirstArray);
            int[,] SecondArray = new int[5, 5];
            SecondArray = SecondArrayInit(FirstArray);
            Console.WriteLine();
            PrintArray(SecondArray);
        }

        static int[,] Init()
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

        static void PrintArray(int[,] array)
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

        static int[,] SecondArrayInit(int[,] array)
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

        static int findMax(int [,] mat, int i, int j)
        {

            int max = 0;
            int k = 0;

            for (int a = i; a < 5; a++, k++)
            {
                for (int b = (j - k < 0 ? 0 : j - k); b <= (j + k > 5 - 1 ? 5 - 1 : j + k); b++)
                    if (mat[a,b] > max)
                        max = mat[a,b];
            }
            return max;
        }
    }
}
