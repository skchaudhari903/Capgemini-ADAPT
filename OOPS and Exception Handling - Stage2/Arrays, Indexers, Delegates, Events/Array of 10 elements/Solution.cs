/*Write a program to initialize a single dimensional array of ten elements with multiples of 2.  After initialization, display the contents of the array.
Note :First number in the ouput series must be 2 .
*/

using System;

namespace LearnCsharp
{

	class SingleDimArray
	{
	    public static void Main(string[] args) 
	    {
            int[] iArray=new int[10];
            
	        for(int i = 1, j = 0; i <= iArray.Length; i++)
	            iArray[j++] = 2 * i;

            foreach (var item in iArray)
            {
                Console.WriteLine((item)); 
            }
            
        }

	}

}