/*Below are the details for open-tickets, in-progress ticket and closed tickets for all the call centre employees which needs to be efficiently stored in a memory using arrays.  
Use DisplayArray function to display the same.

EmpNo	Open	InProgress	Closed
1	    5	    7	
2	    8	    6	        4
3	    9	
*/

using System;

namespace LearnCsharp
{
 
 class JaggedArray
 {
     public static void Main(string[] args) 
     {
         int[][] iTickets;
         iTickets = new int[3][];
         iTickets[0] = new[] {1, 5, 7};                 //For Emp1
         iTickets[1] = new[] {2, 8, 6, 4};              //For Emp2
         iTickets[2] = new[] {3, 9};                    //For Emp3
        
         DisplayArray(iTickets);
        }

        private static void DisplayArray(int[][] iTickets)
        {
            for(int i = 0; i < iTickets.Length; i++){
                for(int j = 0; j < iTickets[i].Length; j++){
                    Console.Write(iTickets[i][j] + "|");
                }
                Console.WriteLine();
            }
        }
     
    }
}