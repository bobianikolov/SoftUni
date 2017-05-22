using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MatrixPolindromes
{
    class MatrixPolindromes
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int matrixRows = array[0];
            int matrixCols = array[1];
            string[,] matrix = new string[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
                }
            }
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    } 
}
