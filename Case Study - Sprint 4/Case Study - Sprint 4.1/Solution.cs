using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

	class Customer
	{
	    private int cid;
	    private string cname, password, city, state, zip, country;
	    
	    public Customer(){ }
	    public Customer(int cid, string cname, string password, string city, string state, string zip, string country){
	        this.cid = cid;
	        try {
                if(cname.Length < 6)
	                throw new InvalidNameException("Invalid Name");
            } catch(InvalidNameException e) {
                Console.WriteLine("User defined exception: {0}", e.Message);
            }
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
	    private int? tid, min_age, max_age, quantity;
	    private string tname, type;
	    private float? price;
	    private double? rental_amount;
	    
	    public Toy(){ }
	    
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
	    public int? Tid
	    {  get { return tid;}
	      set{tid=value;  }}
        public string Tname
	  {  get { return tname;}
	      set{tname=value;  }}
	      public string Type
	  {  get { return type;}
	      set{type=value;  }}
	      public int? Min_age
	  {  get { return min_age;}
	      set{min_age=value;  }}
	      public int? Max_age
	  {  get { return max_age;}
	      set{max_age=value;  }}
	      public float? Price
	  {  get { return price;}
	      set{price=value;  }}
	      	public int? Quantity
	  {  get { return quantity;}
	      set{quantity=value;  }}
	      public double? Rental_amount
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

  
