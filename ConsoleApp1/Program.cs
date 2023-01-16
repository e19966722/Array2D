using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[,] array= CreatArray(4,3);
            Print(array);
            PrintDiagonal(array);
            Console.WriteLine($"Max : {GetMax(array)}");
            Console.ReadKey();
        }
        /// <summary>
        /// Find the max element of two-dimensional array
        /// </summary>
        /// <param name="array">given any array of Int32 type</param>
        /// <returns>Return maximum element of array</returns>
        static int GetMax(int[,] array)
        {
            int max = array[0,0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i,j])
                    {
                        max = array[i, j];              
                    }
                    
                }
                Console.WriteLine();
            }


            return max; 
        }
        /// <summary>
        ///  Print diagonal of a two-dimensional array
        /// </summary>
        /// <param name="array">two dimensional array</param>
        static void PrintDiagonal(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        Console.Write(array[i, j]);
                    }
                    else
                    {
                        Console.Write("- - ");
                    }
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Print given array
        /// </summary>
        /// <param name="array">two dimensional array</param>
        static void Print(int[,] array)
        {
            for (int i=0; i<array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write( array[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Creates array
        /// </summary>
        /// <param name="height">height of a two-dimensional array </param>
        /// <param name="width"> width of two dimensional array</param>
        /// <returns></returns>
        static int[,] CreatArray(int height, int width)
        {
            Random random = new Random();
            int[,] array = new int[height, width];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j]=random.Next(10,100);
                }
            }
            return array;
        }
    }
}
