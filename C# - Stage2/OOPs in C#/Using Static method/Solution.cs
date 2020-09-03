using System;

namespace LearnCsharp
{
public class Utility {

	public static int fahrenheitToCelcius(double farhenheit)
	{
	    double celcius = (farhenheit - 32) * 5 / 9;
	    return (int)Math.Round(celcius);
	}

	public static string getLevel(int[] array) 
	{
		int sum = 0;
		foreach (int a in array) {
			sum = sum + a;
		}
		if(sum >= 100) return "HIGH";
		else if(sum >= 70) return "MEDIUM";
		else return "LOW";
	}
}

public	class StaticMethods{
	    public static void Main(string[] args)
	    {
		    int option = Convert.ToInt32(Console.ReadLine());
		    switch (option) {
        		case 1:
        		    double farhenheit = double.Parse(Console.ReadLine());
                    Console.WriteLine(Utility.fahrenheitToCelcius(farhenheit));
        			break;
        		case 2:
                    int size = Int32.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    for(int i = 0; i < size; i++){  
	    	            arr[i] = Convert.ToInt32(Console.ReadLine());  		
                    }  
                    Console.WriteLine(Utility.getLevel(arr));
        			break;
        		default:
        		    Console.WriteLine("Invalid Option");
    			    break;
    		}
	    }
	}
}