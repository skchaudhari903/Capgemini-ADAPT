/*Problem Statement - Armstrong Number
Complete the main method and user defined function to find whether a given 3-digit number is an Armstrong number or not.
*/

using System;

namespace LearnCsharp
{
	class Armstrongnumber{

        static int power(int n, int r)
        {
            return (int)Math.Pow(n, r);
        }
        
        public static void Main(String[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            
            int temp = num, rem, sum = 0;
            if((int)(Math.Log10((double)num) + 1) == 3){
                while (temp > 0)
                {
                    rem = temp % 10;      
                    sum = sum + (power(rem, 3));      
                    temp = temp / 10; 
                }
                if (num == sum)
                    Console.WriteLine("ARMSTRONG");
    	        else
    	             Console.WriteLine("NOT ARMSTRONG");
                }
            else{
                Console.WriteLine("INVALID_INPUT");
            }   
      	}
    }

}