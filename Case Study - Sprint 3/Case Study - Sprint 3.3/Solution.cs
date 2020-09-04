using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Source {
	class Source {
	  public static string[, ,] customers;
		static void Main(string[] args) {
		    List<string> customer = new List<string>();
			for(int i = 0; i < 3; i++){
			    string name = Console.ReadLine();
			    customer.Add(name);
			}
			
            customer.Sort();
            
            string str = customer[0];
            char[] seperator = {','}; 
            String[] strlist = str.Split(seperator); 

            string str1 = customer[1];
            String[] strlist1 = str1.Split(seperator); 
            
            string str2 = customer[2];
            String[] strlist2 = str2.Split(seperator); 
        
            var myList = new List<string>();
            myList.AddRange(strlist);
            myList.AddRange(strlist1);
            myList.AddRange(strlist2);
            string[] arr3 = myList.ToArray();
        
            string rl = Console.ReadLine();
            if (arr3.Contains(rl)) 
                Console.WriteLine(rl+":true"); 
            else
                Console.WriteLine(rl+":false"); 
            string rl1 = Console.ReadLine();
            if (arr3.Contains(rl1)) 
                Console.WriteLine(rl1+":true"); 
            else
                Console.WriteLine(rl1+":false"); 
		}
	}
}
