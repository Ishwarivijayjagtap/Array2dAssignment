using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2d
{
    internal class SumOfRowsAndcolumn
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Sum of Rows
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    rowSum += arr[i, j];
                }
                Console.WriteLine($"Sum of row {i + 1}: {rowSum}");
            }

            // Sum of Columns
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int colSum = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    colSum += arr[i, j];
                }
                Console.WriteLine($"Sum of column {j + 1}: {colSum}");
            }
        }
    }
}
