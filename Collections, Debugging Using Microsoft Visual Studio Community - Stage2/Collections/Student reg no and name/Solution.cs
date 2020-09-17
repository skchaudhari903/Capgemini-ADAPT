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
        for(int i = 0; i < data.Length-1; i += 2)
            student_table.Add(data[i], data[i+1]);
    }

    public static void DisplayTable(Hashtable ht)
    {
        foreach(DictionaryEntry de in ht)
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
    }
}