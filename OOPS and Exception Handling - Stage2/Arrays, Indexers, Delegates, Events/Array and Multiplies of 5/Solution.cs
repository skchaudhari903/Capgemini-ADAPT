/*Write a program to initialize a single dimensional array of any size with integer values . Display the complete array content with count of the numbers which are divisible by 5 to the end.
Size of the array is first input to the program followed by the elements of the array.
*/

using System;

namespace LearnCsharp
{
	
	class CountOfDivideByFive
	{
	    public static void Main(string[] args)
	    {
	        int[] iArray;
	        int size = Convert.ToInt32(Console.ReadLine());
            iArray = new int[size];
            int iCount = 0;
            
            for (int iVal1 = 0; iVal1 < size; iVal1++)
            {
                iArray[iVal1] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int item in iArray)
            {
                Console.WriteLine(item);
                if(item % 5 == 0) iCount++;
            }
            Console.WriteLine("Count of elements divide by 5: " + iCount);
	    }
	}

}