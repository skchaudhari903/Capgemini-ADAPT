using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

    class Customer
	{
	    private int cid;
	    private string cname, password, city, state, zip, country;
	    
	    public Customer(){
	        
	    }
	    public Customer(int cid, string cname, string password, string city, string state, string zip, string country){
	        this.cid = cid;
	        this.cname = cname;
	        this.password = password;
	        this.city = city;
	        this.state = state;
	        this.zip = zip;
	        this.country = country;
	    }
	        public int Cid
    	  {  get { return cid;}
    	      set{cid=value;  }}
            public string Cname
    	  {  get { return cname;}
    	      set{cname=value;  }}
    	    public string Password
    	  {  get { return password;}
    	      set{password=value;  }}
    	    public string City
    	  {  get { return city;}
    	      set{city=value;  }}
    	    public string State
    	  {  get { return state;}
    	      set{state=value;  }}
    	    public string Zip
    	  {  get { return zip;}
    	      set{zip=value;  }}
    	    public string Country
    	  {  get { return country;}
    	      set{country=value;  }
    	  }
	    
	    public override string ToString(){
	        return "CustomerId-"+cid+",CustomerName-"+cname+",Password-"+password
	        +",City-"+city+",State-"+state+",Zip-"+zip+",Country-"+country;
	    }
	}
	
	class Toy 
	{
	    private int tid, min_age, max_age, quantity;
	    private string tname, type;
	    private float price;
	    private double rental_amount;
	    
	    public Toy(){
	        
	    }
	    public Toy(int tid,string tname, string type, int minage, int maxage, float price, int qty, double rent_amount){
	        this.tid = tid;
	        this.tname = tname; 
	        this.type = type;
	        this.min_age = minage;
	        this.max_age = maxage;
	        this.price = price;
	        this.quantity = qty;
	        this.rental_amount = rent_amount;
	    }
	    public int Tid
	    {  get { return tid;}
	      set{tid=value;  }}
        public string Tname
	  {  get { return tname;}
	      set{tname=value;  }}
	    public string Type
	  {  get { return type;}
	      set{type=value;  }}
	    public int Min_age
	  {  get { return min_age;}
	      set{min_age=value;  }}
	    public int Max_age
	  {  get { return max_age;}
	      set{max_age=value;  }}
	    public float Price
	  {  get { return price;}
	      set{price=value;  }}
	    public int Quantity
	  {  get { return quantity;}
	      set{quantity=value;  }}
	    public double Rental_amount
	  {  get { return rental_amount;}
	      set{rental_amount=value;  }
	  }
	    
	    public override string ToString(){
	        return "ToyId-"+tid+",ToyName-"+tname+",Type-"+type+",MinAge-"+min_age
	        +",MaxAge-"+max_age+",Price-"+price+",Quantity-"+quantity+",RentalAmount-"+rental_amount;
	    }
	}
	
	public class InvalidNameException : Exception{
	    public InvalidNameException(){}
	    public InvalidNameException(string message): base(message) {}
	}
	
	public class InvalidAgeException : Exception{
	    public InvalidAgeException(){}
	    public InvalidAgeException(string message): base(message) {}
	}

interface CustomerService 
{
    void Insert();
    bool Search(int id);
    bool Search(string name);
    void Display();
}

interface ToyService 
{
    void Insert();
    bool Search(int id);
    bool Search(string name);
    void Display();
}

class CustomerServiceImpl :CustomerService
{
    public static List<Customer> CustomerArray = new List<Customer>();
    public void Insert(){
       // CustomerArray.Add();
    }
    public void Display(){
        foreach(Customer str in CustomerArray) 
        { 
            Console.WriteLine(str); 
        } 
    }
    public bool Search(int id){
        return true;
    }
    public bool Search(string name){
        return true;
    }
}
class ToyServiceImpl :ToyService
{
    public static List<Toy> ToyArray = new List<Toy>();
    
    public void Insert(){
        //ToyArray.Add();
    }
    
    public void Display(){
        foreach(Toy str in ToyArray) 
        { 
            Console.WriteLine(str); 
        } 
    }
    public bool Search(int id){
        return true;
    }
    public bool Search(string name){
        return true;
    }
}

class ElectronicToy:Toy  
{
    public int numberofbatteries;
    public string operatingmode;
}
 class MusicalToy:Toy  
{
    public int noOfSpeakers;
} 

class TestApp
{
 public static void Main() 
 {

 }
 }

