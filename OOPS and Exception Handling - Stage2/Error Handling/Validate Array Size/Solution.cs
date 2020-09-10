/*Create a program with an integer array of size 5, initialize the array with  values entered by the user.  
If the count of input elements is greater than array size, display a message “Program tried to access index beyond the array size”.  
If the incoming values are not integers,  then display a message “General Exception”, else display the list of values in the integer array.
*/

using System;

namespace LearnCsharp
{

	class TrapRunTimeErrors
	{
	    public static void Main(string[] args)
	    {
            int[] iValue;
            iValue = new int[5];
            
            try{
                for (int iCount = 0; iCount < 10; iCount++)
                {
                    iValue[iCount] = int.Parse(Console.ReadLine());    
                }
                
                foreach (int iCurItem in iValue)
                {
                    Console.WriteLine(iCurItem);
                }
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.WriteLine("Program tried to access index beyond the array size");
            }
            catch(Exception)
            {
                Console.WriteLine("General Exception");
            }

	    }
	}
}