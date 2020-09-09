/*Problem Statement - Find Maximum and Minimum Age
Complete the main method to accept the age of n students and find the maximum and minimum age .
*/

using System;
 
namespace LearnCsharp
{
	class FindMaxMinAge{
	    public static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 1 || n > 20)
        {
            Console.WriteLine("INVALID_INPUT");
        }
        else
        {
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
            
			Array.Sort(array);
			
			int min = array[0]; 
            Console.WriteLine("MIN=" + min);
			
			int max = array[n-1];
            Console.WriteLine("MAX=" + max);
        }
        
	    }
	}
}