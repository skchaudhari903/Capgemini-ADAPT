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
            
            int max = array[0];
            int min = array[0];
            for(int i = 1; i < n; i++){
                if(max < array[i])
                    max = array[i];
                if(min > array[i])
                    min = array[i];
            }
            Console.WriteLine("MIN=" + min);
            Console.WriteLine("MAX=" + max);
        }
        
	    }
	}
}