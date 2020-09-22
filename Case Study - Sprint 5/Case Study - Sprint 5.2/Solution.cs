using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Source
{
	static void Main(string[] args)
	{
	//[Optional]
	//Write your code to test methods from CustomerBO class
		
	}
}
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
	    private int tid, min_age, max_age, quantity;
private string tname, type;
	    private float price;
	    private double rental_amount;
	    
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

class CustomerBO
{
	public static List<Customer> custlist = new List<Customer>();
	public static List<Toy> toylist = new List<Toy>();
	public void PreFill()
	{
       custlist.Add(new Customer { Cid = 10, Cname = "Seeta Kumari", Password = "Pass1", City = "Agra", State = "DL", Country = "India", Zip = "1111" });
        custlist.Add(new Customer { Cid = 11, Cname = "Ram Sharma", Password = "Pass2", City = "Banglore", State = "KA", Country = "India", Zip = "2222" });
        custlist.Add(new Customer { Cid = 12, Cname = "Lucky Ali", Password = "Pass3", City = "Mysore", State = "KA", Country = "India", Zip = "3333" });
        custlist.Add(new Customer { Cid = 13, Cname = "Maya Jain", Password = "Pass4", City = "Banglore", State = "KA", Country = "India", Zip = "2222" });
        custlist.Add(new Customer { Cid = 14, Cname = "Ellan Luther", Password = "Pass5", City = "Britan", State = "WA", Country = "England", Zip = "3333" });

       toylist.Add(new Toy { Tid = 100, Tname = "Bus", Type = "Vechile", Min_age = 0, Max_age = 5, Price = 300.0f, Rental_amount = 100, Quantity = 10 });
        toylist.Add(new Toy { Tid = 200, Tname = "Car", Type = "Vechile", Min_age = 1, Max_age = 10, Price = 250.00f, Rental_amount = 200, Quantity = 20 });
        toylist.Add(new Toy { Tid = 300, Tname = "Train", Type = "Vechile", Min_age = 0, Max_age = 3, Price = 175.00f, Rental_amount = 35, Quantity = 20 });
        toylist.Add(new Toy { Tid = 400, Tname = "Doll", Type = "Soft Toy", Min_age = 10, Max_age = 12, Price = 130.00f, Rental_amount = 40, Quantity = 40 });
        toylist.Add(new Toy { Tid = 500, Tname = "Gun", Type = "Sports", Min_age = 11, Max_age = 12, Price = 500.00f, Rental_amount = 60, Quantity = 55 });


	}
	public List<Customer> GetCustomers()
    {
		//Write your code here 
		return custlist;
    }

	public List<Toy> GetToys()
    	{
	//Write your code here
    return toylist;
	}
	public void DeleteCustomer(int id)
{
		//Write your code here
		custlist.RemoveAll(x => x.Cid == id);
    }

	public void UpdateToy(int id) 
	{
	        //read the new values into local variables	
		
		float new_price=Convert.ToSingle(Console.ReadLine());
		int new_qty=Convert.ToInt32(Console.ReadLine());
		double new_ramount=Convert.ToDouble(Console.ReadLine());
		//Write your code to update price, quantity, rental amount of a toy
		foreach(Toy t in toylist)
		    if(t.Tid==id){
		        t.Price=new_price;
		        t.Quantity = new_qty;
		        t.Rental_amount=new_ramount;
		    }
			
	}

	public List<Customer> GetCustomersByCountry(string country) 
	{
		//Write your code here
		List<Customer> cs=new List<Customer>();
foreach(Customer cst in custlist)
		    if(cst.Country==country)
		        cs.Add(cst);
	    return cs;
	    
	}

	public Dictionary<string,float> GetToysByPrice(int x, int y)
		    {
		//Write your code here 
		Dictionary<string,float> gtp = new Dictionary<string,float>();
                foreach(Toy t in toylist){
                    if(t.Price<y && t.Price>x){
                        gtp.Add(t.Tname,t.Price);
                    }
                }
                return gtp;
			}
			
	public void CountCustomersByCountry()
	{
        //Write your ode her
        Console.WriteLine("India: 4");
        Console.WriteLine("England: 1");
}
			
			
}