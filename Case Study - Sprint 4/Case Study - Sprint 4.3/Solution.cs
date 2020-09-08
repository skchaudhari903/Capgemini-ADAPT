using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

class ToyRental 
{
    private int rid, cid, tid, amount_PerDay, fine;
    private DateTime startDate = new DateTime(); 
    private DateTime endDate = new DateTime();
    private double total_Amount;
    private string status;
	    
    public ToyRental(){ }
    public ToyRental(int rid,int cid,int tid,DateTime startdate,DateTime enddate,int AmtPerDay , double TotalAmt , int fine,string status){
        this.rid = rid;
        this.cid = cid;
        this.tid = tid;
        startdate = startdate;
        enddate = enddate;
        this.amount_PerDay = AmtPerDay;
        this.total_Amount = TotalAmt;
        this.fine = fine;
        this.status = status;
    }
    public int Rid{   
        get { return rid;}
        set{rid=value;  }}
    public int Cid{   
        get { return cid;}
        set{cid=value;  }}
    public int Tid{   
        get { return tid;}
        set{tid=value;  }}
    public int Amount_PerDay{   
        get { return amount_PerDay;}
        set{amount_PerDay=value;  }}
    public int Fine{   
        get { return fine;}
        set{fine=value;  }}
    public DateTime StartDate{   
        get { return startDate;}
        set{startDate=value;  }}
    public DateTime EndDate{   
        get { return endDate;}
        set{endDate=value;  }}
    public double Total_Amount{   
        get { return total_Amount;}
        set{total_Amount=value;  }}
    public string Status{   
        get { return status;}
        set{status=value;  }}
    	      
  	public void PrintRentalDetails() 
  	{
  	    Console.WriteLine("ToyRental Details");
  	}
    public double  GetTotalAmount(int rentalid) 
    {
        return total_Amount;
    }
  	public int Add(int n1, int n2) 
  	{
  	    return n1 + n2;
  	}
}
class Program 
{
    public static void Main() 
    {
       
    }
    
 }