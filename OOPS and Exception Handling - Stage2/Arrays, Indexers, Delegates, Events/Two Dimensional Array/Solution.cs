/*Create a two dimensional integer array of size (2 * 2) and assign values from user input.   The output should be displayed in the form of 2*2 matrix with sum of rows and columns as show below. The last column and last row is the sum.
1|2|3
3|4|7
4|6|10
*/

using System;

namespace LearnCsharp
{
   
	class TwoDimArray
	{
	    public static void Main(string[] args)
	    {
            int [,]iMatrix;
            iMatrix = new int[3,2];

            iMatrix[0, 0] = int.Parse(Console.ReadLine());
            iMatrix[0, 1] = int.Parse(Console.ReadLine());
            iMatrix[1, 0] = int.Parse(Console.ReadLine());
            iMatrix[1, 1] = int.Parse(Console.ReadLine());

            int iRowSum;
            int [] arr = new int[2];
            
            iRowSum = 0;
            for (int i = 0; i < 2; i++)
            {
                arr[i]=0;
                iRowSum=0;
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(iMatrix[i,j] + "|");
                    iRowSum = iRowSum + iMatrix[i,j];
                    arr[i] = arr[i] + iMatrix[j,i];
                }
                Console.Write(iRowSum);
                Console.WriteLine();
            }
            Console.WriteLine( arr[0]+"|" + arr[1] + "|" + (arr[0] + arr[1]) );
        }
    }
}