/*Write a program that behaves as mentioned below :



Define an abstract base class "A" .Class A contains 2 abstract methods .

void method1()
void method3()
Class A also contains void non-abstract method2().Define the method() such that , when invoked it prints "I am a non-abstract method from abstract class" on the console.



Define class "B" inherited from class A .Override methid1() inside class B insuch a way that it prints " I am an abstract method overrriden at class B" when invoked.

In the Main method write your code to invoke method1(),method2().
*/

using System;

abstract class A
{
    public abstract void method1();
    public abstract void method3();
    public void method2(){
        Console.WriteLine("I am a non-abstract method from abstract class");
    }
}

class B : A
{
    public override void method1(){
        Console.WriteLine("I am an abstract method overriden at class B");
    }
    public override void method3(){}
}

public class AbstractClassExample
{
    public static void Main(string[] args)
    {
        B b = new B();
        b.method1();
        b.method2();
    }

}
