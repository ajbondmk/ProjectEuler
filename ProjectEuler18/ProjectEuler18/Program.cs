using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler18
{
    class Program
    {
        static void Main(string[] args)
        {
            //By starting at the top of the triangle below and moving to adjacent numbers on the row below, find the maximum total.

            int[] row1 = {75};
            int[] row2 = {95, 64};
            int[] row3 = {17, 47, 82};
            int[] row4 = {18, 35, 87, 10};
            int[] row5 = {20, 04, 82, 47, 65};
            int[] row6 = {19, 01, 23, 75, 03, 34};
            int[] row7 = {88, 02, 77, 73, 07, 63, 67};
            int[] row8 = {99, 65, 04, 28, 06, 16, 70, 92};
            int[] row9 = {41, 41, 26, 56, 83, 40, 80, 70, 33};
            int[] row10 = {41, 48, 72, 33, 47, 32, 37, 16, 94, 29};
            int[] row11 = {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14};
            int[] row12 = {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57};
            int[] row13 = {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48};
            int[] row14 = {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31};
            int[] row15 = {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23};
            int[][] triangle = {row1, row2, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12, row13, row14, row15};

            for (int r = triangle.Length - 1; r > 0; r--)
            {
                int[] currentRow = triangle[r];
                for (int i = 0; i < currentRow.Length - 1; i++)
                {
                    if (currentRow[i] > currentRow[i + 1]) triangle[r - 1][i] += currentRow[i];
                    else triangle[r - 1][i] += currentRow[i + 1];
                }
            }
            Console.WriteLine(row1[0]);
            Console.ReadLine();
        }
    }
}