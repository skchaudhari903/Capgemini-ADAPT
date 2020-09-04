using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Source {
	class Source {
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
            Console.WriteLine(strlist[0]+","+strlist[1]); 
            
            string str1 = customer[1];
            String[] strlist1 = str1.Split(seperator); 
            Console.WriteLine(strlist1[0]+","+strlist1[1]); 
            
            string str2 = customer[2];
            String[] strlist2 = str2.Split(seperator); 
            Console.WriteLine(strlist2[0]+","+strlist2[1]); 
		}
    }
}