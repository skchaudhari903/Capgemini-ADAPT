/*
Define the class "Student" as per the given specification :
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
//write your code here	
     private int irollNo;
     private string sName,sAddress,sCollege;
     
   public Student(){
        this.irollNo=0;
        this.sName=null;
        this.sAddress=null;
        this.sCollege=null;
   }
   public Student(int r){
       this.irollNo=r;
   }
   public Student(int r,String n){
       this.irollNo=r;
       sName=n;
   }
   public Student(int rollno,String name,String address){
       this.irollNo=rollno;
       this.sName=name;
       this.sAddress=address;
   }
   public void changeCollege(){
       string college=Console.ReadLine();
       this.sCollege=college;
   }
   public void input(){
       int rollno=Convert.ToInt32(Console.ReadLine());
       string name=Console.ReadLine();
       string address=Console.ReadLine();
       string college=Console.ReadLine();
       this.irollNo=rollno;
       this.sName=name;
       this.sAddress=address;
       this.sCollege=college;
   }
   public void input(int r,String n){
       this.irollNo=r;
       this.sName=n;
   }
   public void input(int r,String n,String a){
       this.irollNo=r;
       this.sName=n;
       this.sAddress=a;
   }
   public void input(int r){
       this.irollNo=r;
   }
   public void output(){
       Console.WriteLine(this.irollNo + this.sName + this.sAddress + this.sCollege);
   }
  }
