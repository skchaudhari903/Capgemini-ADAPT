/*Complete the implementation of Main() to get below output



Sample Output :

I am the default constructor

X value is 100


Note : Create object of the Test class in the Main() .Follow the instruction given in the comment section
*/

using System;
public class Test
{

    public int x;
    public Test()
    {
        Console.WriteLine("I am the default constructor");
    }
   public Test(int x) 
    {
        this.x = x;
        Console.WriteLine("X value is "+x);
    }
}



public class Program
{

    public static void Main(string[] args)
    {
        Test t =new Test();
        Test t1 = new Test(100);
        Console.WriteLine();
    }

}
