using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;
using System.Runtime.Serialization;

	//Section A
	[Serializable]
	class Customer
	{
	    private int cid;
	    private string cname,password,city,state,zip,country;
	    
	    public Customer()
	  {}
	  public Customer(int cid,string cname,string password,string city,string state,string zip,string country)
	  { 
	          try {
                if(cname.Length < 6)
	                throw new InvalidNameException("Invalid Name");
            } catch(InvalidNameException e) {
                Console.WriteLine("User defined exception: {0}", e.Message);
            }
	  
	      this.cid=cid;
          this.cname=cname;
          this.password=password;
          this.city=city;
          this.state=state;
          this.zip=zip;
          this.country=country;
	      
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
	      set{country=value;  }}
	      
  public override string ToString()
	  {
	      string s1="CustomerId-"+this.cid;
	      string s2="CustomerName-"+this.cname;
	      string s3="Password-"+this.password;
	      string s4="City-"+this.city;
	      string s5="State-"+this.state;
	      string s6="Zip-"+this.zip;
	      string s7="Country-"+this.country;
	       
	      string res=s1+","+s2+","+s3+","+s4+","+s5+","+s6+","+s7;
	      return res;
	  }
}
	
	
//Section B	
[Serializable]
	class Toy 
	{
		
	   private int tid,min_age,max_age,quantity;
		private string tname,type;
		private float price;
		private double rental_amount;
		
	    public Toy()
	    {}
	  public Toy(int tid,string tname, string type, int min_age, int max_age, float price, int quantity, double rental_amount){
	        this.tid = tid;
	        this.tname = tname; 
	        this.type = type;
	        try{
	            if(min_age < 0)
	                throw new InvalidAgeException("Invalid Age");
	        }catch(InvalidAgeException){
	            Console.WriteLine("Invalid");
	        }
	        this.min_age = min_age;
	        try{
	            if(max_age > 12)
	                throw new InvalidAgeException("Invalid Age");
	        }catch(InvalidAgeException){
	            Console.WriteLine("Invalid");
	        }
	        this.max_age = max_age;
	        this.price = price;
	        this.quantity = quantity;
	        this.rental_amount = rental_amount;
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
	      set{rental_amount=value;  }}
	      
	    public override string ToString()
	     {
	      string s1="ToyId-"+this.tid;
	      string s2="ToyName-"+this.tname;
	      string s3="Type-"+this.type;
	      string s4="MinAge-"+this.min_age;
	      string s5="MaxAge-"+this.max_age;
	      string s6="Price-"+this.price;
	      string s7="Q=uantity-"+this.quantity;
	      string s8="RentalAmount-"+this.rental_amount;
	       
	      string res=s1+","+s2+","+s3+","+s4+","+s5+","+s6+","+s7+","+s8;
	      return res;
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
	class CustomerServiceImpl
	{
	  public static List<Customer> CustomerArray = new List<Customer>();
    public void Insert()
    {
       // CustomerArray.Add();
    }
    public void Display()
    {
        foreach(Customer str in CustomerArray) 
        { 
            Console.WriteLine(str); 
        } 
    }
    public bool Search(int id)
    {
        return true;
    }
    public bool Search(string name)
    {
        return true;
    }
	  
	    public FileStream SerializeCustomer( Customer c)
	    {
	    
	    FileStream fs=new FileStream("Customer.txt",FileMode.Create);
	    
	    
	      BinaryFormatter formatter = new BinaryFormatter();
        try
        {
            formatter.Serialize(fs,c);
        }
        catch (SerializationException e)
        {
            Console.WriteLine( e.Message);
            throw;
        }
        finally
        {
            fs.Close();
        }
        return fs;
	    
	    }
	    
	    public Customer DeSerializeCustomer( FileStream fs)
	    {
	         Customer c=new Customer();

        
        
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();

            
            c = (Customer) formatter.Deserialize(fs);
        }
        catch (SerializationException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        finally
        {
            fs.Close();
        }

        
      return c;
	      
	    }
	}
	class ToyServiceImpl
	{
	  public static List<Toy> ToyArray = new List<Toy>();
    
    public void Insert()
    {
        //ToyArray.Add();
    }
    
    public void Display()
    {
        foreach(Toy str in ToyArray) 
        { 
            Console.WriteLine(str); 
        } 
    }
    public bool Search(int id)
    {
        return true;
    }
    public bool Search(string name)
    {
        return true;
    }
	  
	  
	    public FileStream SerializeToy( Toy t)
	    {   
	    
	     FileStream fs=new FileStream("Toy.txt",FileMode.Create);
	    
	    
	      BinaryFormatter formatter = new BinaryFormatter();
        try
        {
            formatter.Serialize(fs,t);
        }
        catch (SerializationException e)
        {
            Console.WriteLine( e.Message);
            throw;
        }
        finally
        {
            fs.Close();
        }
        return fs;  
	    }
	    
	    public Toy DeSerializeToy( FileStream fs)
	    {
	       Toy t=new Toy();

        
        
        try
        {
            BinaryFormatter formatter = new BinaryFormatter();

            
            t = (Toy) formatter.Deserialize(fs);
        }
        catch (SerializationException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
        finally
        {
            fs.Close();
        }

        
      return t;
	      
	      
	    }
	}
	
	class TestApp 
	{
	 public static void Main(){
    // Implement Main to check your code..
  } 
	  
	}