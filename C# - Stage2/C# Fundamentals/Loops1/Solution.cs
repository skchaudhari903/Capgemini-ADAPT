/*Problem Statement - Decimal To Binary
Complete the main method of DecimalToBinary class with appropriate code to accept an integer in the range 1 to 999 and 
display the binary equivalent of that number as output.
*/

using System;

namespace LearnCsharp
{
	class Decimaltobinary{
	    public static void Main(string[] args) {
			
            int n = Convert.ToInt32(Console.ReadLine());
            string result; 
  
            if(n < 1 || n > 999){
                Console.WriteLine("INVALID_INPUT");
            }
            else{
                result = "";
                while (n > 1)
                {
                    int remainder = n % 2;
                    result = Convert.ToString(remainder) + result;
                    n /= 2;
                }
                result = Convert.ToString(n) + result;
                Console.WriteLine("{0}", result);
            }
	    }
	}

}