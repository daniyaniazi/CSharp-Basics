using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLevel2
{
    class Arrays
    {
        static void Main()
        {
            // Array declaration
            int[] arr;
            //initialization
            arr = new int[8];
            // item filling
            arr[0] = 55;
            arr[1] = 56;


            //single statement
            int[] arr2 = new int[8];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = i * i;
            }

            int[] arr3 = { 1, 2, 3, 4, 4, 5 };
            int[] arr4 = new int[] { 22, 33, 44, 55, 660 };
            char[] charinp = { 'p', 'a', 'k' };

            // 2 types of 2D array
            // Rectangular array
            // Jagged array

            ///////////////RECTANGULAR ///////////////
            int[,] twoDarr; //declaration
            twoDarr = new int[2, 2];

            twoDarr[0, 0] = 1;
            twoDarr[0, 1] = 2;
            twoDarr[1, 0] = 3;
            twoDarr[1, 1] = 4;
            // dimension -> GetLength
            for (int i = 0; i < twoDarr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDarr.GetLength(1); j++)
                {
                    Console.WriteLine(twoDarr[i, j]);
                }
            }

            /////////////JAGGED////////////////////
            int[][] arrjag = new int[2][]; // error if we provide no col at the time of declaration
            arrjag[0] = new int[2]; // columns
            arrjag[1] = new int[2];

            twoDarr[0, 0] = 11;
            twoDarr[0, 1] = 12;
            twoDarr[1, 0] = 13;
            twoDarr[1, 1] = 14;

            for (int i = 0; i < arrjag.Length; i++) // no of rows
            {
                for (int j = 0; j < arrjag[i].Length; j++) // no of element in row 
                {
                    Console.WriteLine(twoDarr[i, j]);
                }
            }

            Console.ReadLine();

        }
    }
}

