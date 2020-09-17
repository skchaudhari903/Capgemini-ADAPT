/*Create a program which will accept list of student names as input, these names have to be filtered, sorted and displayed, 
filter criteria is to ensure that names do not have values like “Nobody”, “Somebody”.
*/

using System;

using System.Collections;

namespace LearnCsharp
{

	class NamesWithArrayList
	{
	    public static void Main(string[] args)
	    {
	        ArrayList alObj;
            alObj = new ArrayList();
            int max=10;
            string item="";
            for(int i=0;i<max;i++)
            {
                item = Console.ReadLine();
                alObj.Add(item);
            }
            for(int i=0;i<max/2;i++)
            {
                if(alObj.Contains("Nobody")) alObj.RemoveAt(alObj.IndexOf("Nobody"));
                else if(alObj.Contains("Somebody")) alObj.RemoveAt(alObj.IndexOf("Somebody"));
            }
            
            alObj.Sort();
            
            foreach (var item1 in alObj)
            {
                Console.WriteLine(item1);
            }
        }
	}

}