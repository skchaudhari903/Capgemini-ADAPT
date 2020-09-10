/*Create a Student class with RegNo, Name, Topic1, Topic2, Topic3, Topic4, and Topic5 for storing marks for respective topics, these variables should not be accessible from outside the class.  Values for these should be assigned  or retrieved using the numeric indexer.

Define the indexer that behaves as described below :
Sample :
Student s=new Student();
s[0]=100;  //Should Assign the value 100 in Regno
s[1]="Sagar";   //Should Assign the value of name as Sagar
s[2]=300;     //Should Assign the value 300 to Topc1
s[3]=400;    //Should Assign the value 400 to Topc2
s[4]=500;    //Assign the value 500 to Topc3
s[5]=400 ;    //Assign the value 400 to Topc4

int id=s[0];   //Assigns the value of  Regno to id variable
string name=s[1];  //Assigns the value of  Name to name variable
int sub1=s[2];   //Assigns the value of  Topic1 to sub1 variable.
*/

using System;
     class Student
    {
        internal int RegNo;
        internal string Name;
        private int Topic1, Topic2, Topic3, Topic4, Topic5;
		private int length = 7;
        
        public object this[int index]
        {
            set{
                if(index == 0) int.TryParse(value.ToString(), out RegNo);
                if(index == 1)  Name = value.ToString();
                if(index == 2) int.TryParse(value.ToString(), out Topic1);
                if(index == 3) int.TryParse(value.ToString(), out Topic2);
                if(index == 4) int.TryParse(value.ToString(), out Topic3);
                if(index == 5) int.TryParse(value.ToString(), out Topic4);
                if(index == 6) int.TryParse(value.ToString(), out Topic5);
            }
            get{
                if(index == 0) return RegNo;
                if(index == 1) return Name;
                if(index == 2) return Topic1;
                if(index == 3) return Topic2;
                if(index == 4) return Topic3;
                if(index == 5) return Topic4;
                if(index == 6) return Topic5;
                return 0;
            }
        }
        
        public int Length
        {
            get { return length; }
        }

    }
    
