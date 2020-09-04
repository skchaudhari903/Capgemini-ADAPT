using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Source {
	class Source {
	    static string[] toys=new string[5];
		static void Main(string[] args) {
			OrderToys();
			int age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			DisplayToys(age);
		}
		
		public static void OrderToys() 
		{
			for(int i = 0;i<5;i++)
			{
			    toys[i]= Console.ReadLine();
			}
			Array.Sort(toys);
			foreach(string element in toys) 
			{ 
			    Console.WriteLine(element);
			    
			}
		}
		
		public static void DisplayToys(int age)
		{
		    Console.WriteLine(toys[age]);
		}
	}
}