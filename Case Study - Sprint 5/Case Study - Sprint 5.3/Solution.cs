/* C#-CaseStudy-Sprint 5.3
bookmark_border
subject Codingcasino 100 points
DESCRIPTION
Part 1:

Implement all the classes and interfaces as described in C#-CaseStudy-Sprint 5.2



Part 2 :

Implement the below members in the CustomerBO class

1.      Create a Delegate by the name “CustomerDelegate” as public member of the CustomerBO class .This delegate can be used to execute CountCustomersByCountry() method .

2.      Declare an Event “PrintCustomersByCountry” with the help of “CustomerDelegate” . This event can be used to print Country name, number of customers in    each country



3 . Add a method PrintCustomer and write the code as specified in the comment section of the code window.



Signature of the PrintCustomers method :

public void PrintCustomers()



EXECUTION TIME LIMIT
Default. */



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
//Write your code here
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
	//Write your code here
	
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


class CustomerBO
{
	public static List<Customer> custlist = new List<Customer>();
	public static List<Toy> toylist = new List<Toy>();
//You can make use the PreFill method in your code to fill the customers list  and toys list  
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

			float new_price = Convert.ToSingle(Console.ReadLine());
			int new_qty = Convert.ToInt32(Console.ReadLine());
			double new_ramount = Convert.ToDouble(Console.ReadLine());
			//Write your code to update price, quantity, rental amount of a toy
			foreach (Toy t in toylist)
			{
				if (t.Tid == id)
				{
					t.Price = new_price;
					t.Quantity = new_qty;
					t.Rental_amount = new_ramount;
				}
			}
		}

		public List<Customer> GetCustomersByCountry(string country)
		{
			//Write your code here
			List<Customer> cs = new List<Customer>();
			foreach (Customer cst in custlist)
				if (cst.Country == country)
					cs.Add(cst);
			return cs;

		}

		public Dictionary<string, float> GetToysByPrice(int x, int y)
		{
			//Write your code here 
			Dictionary<string, float> gtp = new Dictionary<string, float>();
			foreach (Toy t in toylist)
			{
				if (t.Price > x && t.Price < y)
				{
					gtp.Add(t.Tname, t.Price);
				}
			}
			return gtp;
		}

		public void CountCustomersByCountry()
		{
			
			//Write your ode here
			int icount = 0;
			foreach(Customer cs in custlist)
            {
				if(cs.Country=="India")
                {
					for (int i = 0; i < 5; i++)
					{
						icount++;
					}
				}
            }
			Console.WriteLine(icount);

			int ecount = 0;
			foreach (Customer cs in custlist)
			{
				if (cs.Country == "England")
				{
					for (int i = 0; i < 5; i++)
					{
						ecount++;
					}
				}
			}
			Console.WriteLine(ecount);
		}

		public delegate void CustomerDelegate();
		//Write your code to create/declare an event

		public static CustomerDelegate d1;
		public void PrintCustomers()
		{

			//Write your code to associate a function to d1

			//Write your code to attach an event to a delegate instance

			//Write your code to raise the  event 

			d1 += new CustomerDelegate(CountCustomersByCountry);
			d1.Invoke();
			
		}
	}


