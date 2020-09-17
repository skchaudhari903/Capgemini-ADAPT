/*Create a function to store RegNo and Name of student passed as arguments using an inbuilt collection class. Function has to ensure that there are no duplicate RegNo stored, 
the program should also ensure that RegNo=S420 is not stored.   
Contents needs to be displayed using DisplayTable function.
*/
using System;
using System.Collections;
using System.Collections.Generic;


class StudentDetails
{
    
    public static void GetData(string[] data,Hashtable student_table)
    {
        student_table.Add(data[0], data[1]);
        student_table.Add(data[2], data[3]);
        //student_table.Add(data[4], data[5]);
    }

    public static void DisplayTable(Hashtable ht)
    {
        foreach(DictionaryEntry de in ht)
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
    }
}