/*Problem Statement - Sum Of Prime Numbers
Complete the main method to accept two integers and display the sum of all the prime numbers between these two numbers.
*/

using System;

namespace LearnCsharp
{
	class Sumofprimenumbers{
        
	    public static void Main(string[] args) {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum=0;
    
            if(n1 >= 3 && n2 <= 1000 && n1 < n2){
                for (int i = n2; i >= n1; i--) 
                { 
                    if (checkPrime(i)) 
                        sum = sum + i; 
                }
                Console.WriteLine(sum);
            }
            else
                Console.WriteLine("INVALID_INPUT");
        }
		
        static bool checkPrime(int num) 
        { 
            if(num == 1)  
                return false; 
            for (int i = 2; i * i <= num; i++)  
            { 
                if (num % i == 0)  
                    return false; 
            } 
            return true; 
        }
	}

}