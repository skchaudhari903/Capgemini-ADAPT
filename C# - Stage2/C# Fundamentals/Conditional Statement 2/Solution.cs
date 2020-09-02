/*Problem Statement - Right Angle Triangle
Complete the main method of the class RightAngleTriangle with appropriate code to accept all the 3 sides of a triangle and 
display if the triangle is a right angle triangle or not.
*/

using System;

namespace LearnCsharp
{
	class Rightangletriangle{
        
	    public static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            
            if(a < b && b < c)
                Console.WriteLine("INVALID_INPUT");   
            else{
                int square1 = (b * b) + (c * c);
                int square2 = a * a;
                if(square1 == square2)
                    Console.WriteLine("RIGHT ANGLE TRIANGLE");
                else
                    Console.WriteLine("NOT RIGHT ANGLE TRIANGLE");
            }
	    }

    }
}