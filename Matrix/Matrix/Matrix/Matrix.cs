using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Matrix
    {
        static int row = Convert.ToInt32(Console.ReadLine());
        static int col = Convert.ToInt32(Console.ReadLine());
        Random rand = new Random();

        int[,] matrix = new int[row,col];

        public Matrix ()
        {
            
        }

        public void MakeMatrix ()
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix[j, i] = rand.Next(1, 100);
                }
            }
        }

        public void ShowMatrix ()
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(matrix[j,i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
