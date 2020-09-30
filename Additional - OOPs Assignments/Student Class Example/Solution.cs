/*Define the class "Student" as per the given specification :

Class Name : Student

Private Instance Variables:

rollno :int
 name:String
 address:String
 college :String

Constructors :

Define a Default Constructor to initialize instance variables to zero or null value depending on the data type
Define Parameterized constructor Student(int r) to initialize roll number
Define Parameterized constructor Student(int r, String n) to initialize roll number,name
Define Parameterized constructor Student(int rollno, String name, String address) to initialize roll number,name,college
Methods :

Define changeCollege() to change the name of the college.
Define input() to read values for rollno,name,address from the user
Define input(int r, String n) to to assign new values to roll number,name
Define input(int r, String n, String a) to to assign new values to roll number,name,address
Define input(int r) to to assign new value to roll number
Define output() to print rollno,name,address,college
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public	class Student
{
    private int rollno;
    private string name, address, college;
    
    public Student(){
        this.rollno = 0;
        this.name = null;
        this.address = null;
        this.college = null;
    }
    public Student(int r){
        this.rollno = r;
    }
    public Student(int r, string n){
        this.rollno = r;
        this.name = n;
    }
    public Student(int rollno, string name, string address){
        this.rollno = rollno;
        this.name = name;
        this.address = address;
    }
    
    public void changeCollege(){
        //string college = Console.ReadLine();
        this.college = college;
    }
    public void input(){
        int rollno = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        //string college = Console.ReadLine();
        string address = Console.ReadLine();
        this.rollno = rollno;
        this.name = name;
        //this.college = college;
        this.address = address;
    }
    public void input(int r, String n){
        this.rollno = r;
        this.name = n;
    }
    public void input(int r, String n, String a) {
        this.rollno = r;
        this.name = n;
        this.address = a;
    }
    public void input(int r){
        this.rollno = r;
    }
    public void output(){
        Console.WriteLine(this.rollno+""+this.name+""+this.address+""+this.college);
    }
}
