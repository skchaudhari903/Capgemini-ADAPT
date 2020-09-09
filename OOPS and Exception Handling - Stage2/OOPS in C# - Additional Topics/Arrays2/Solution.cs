/*Problem Statement - Sort Numbers
Complete the main method to Accept n numbers and display the numbers in ascending order as output ,if n is even. 
If n is odd, then display the numbers in descending order
*/

using System;

namespace LearnCsharp
{
	class Sortnumbers{
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
            if(n % 2 != 0)
				Array.Reverse(array);
				
                
            foreach(int element in array)
				Console.Write(element+" ");
        }

        }
	}
}

