using System;

namespace Homework5_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //В двумерном массиве в каждой строке все элементы, расположенные  
            //после максимального, заменить на 0.

            int[,] arr = new int[3, 5]

            {
                        { 2, 45, 89, 7, 79 },
                        { 45, 12, 4, 97, 34 },
                        { 7, 18, 96, 32, 5 }
            };
            int height = arr.GetLength(0);
            int width = arr.GetLength(1);
            
            
            for (int y = 0; y < height; y++)
            {
                int max = 0;
                int maxIndex = -1;
                for (int x = 0; x < width; x++)
                {
                    if (arr[y, x] > max)
                    {
                        max = arr[y, x];
                        maxIndex = x;

                    }
                    
                }
                      
                for (int x = 0; x < width; x++)
                {
                    if (x<=maxIndex) 
                    {
                        Console.Write(arr[y, x] + "  ");
                    }
                    else
                    Console.Write(0 + "  ");
                }
                Console.WriteLine();
            }

          

        }
    }
}
