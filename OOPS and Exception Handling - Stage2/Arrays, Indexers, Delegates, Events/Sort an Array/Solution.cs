using System;
/*Write a program to accept an array of integers. Sort the array in ascending or descending order according to the user’s choice.  
Array elements are entered by the user, with the first line of input indicating A for ascending or D for descending sort followed by the integer values.

*/

namespace LearnCsharp
{

	class ArraySorting
	{
	    public static void Main(string[] args)
	    {
		
            int?[] iArray;            
            iArray = new int?[7];
            int iTemp = 0;
            string sSortType = Console.ReadLine();
            char []sSort = sSortType.ToCharArray();
            String sSortingType = "Descending";
            string str;
            while((str = Console.ReadLine()) != null){
                iArray[iTemp] = Convert.ToInt32(str);
                iTemp++;
            }
            Array.Sort(iArray);
            if(sSort[0] == 'A' || sSort[0] == 'a'){
                sSortingType = "Ascending";
                Console.WriteLine("After {0} Sorting", sSortingType);
                for(int i = 7-iTemp; i < 7; i++)
                    Console.Write(iArray[i]+" ");
            }
            else{
			    Array.Reverse(iArray);
			    Console.WriteLine("After {0} Sorting", sSortingType);  
			     for(int i = 0; i < iTemp; i++)
		            Console.Write(iArray[i]+" ");
		    }
        }

	}

}