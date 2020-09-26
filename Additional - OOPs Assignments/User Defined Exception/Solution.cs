/*Write a program that takes the user's age as input and prints weather he/she is eligible for voting or not .

If the entered age is more than 18 then print a message "Welcome to vote" , otherwise

raise an exception .

If the exception occurs in then catch it in the catch block and print the error message as

'Not eligible to vote'
*/

using System;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string s):base(s)
    {
       
    }
}

public class UserDefinedException
{

    static void ageCheck(int age)
    {
        if(age < 18) throw new InvalidAgeException("Not eligible to vote");
        else Console.WriteLine("Welcome to vote");
    }

    public static void Main(String[] args)
    {
       
        try
        {
            int age = Convert.ToInt32(Console.ReadLine());
            ageCheck(age);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }

}
