using System;

public class SimpleDate
{
    public int day, month, year;
    
    public SimpleDate(int day, int month, int year){
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public int getDay(){
       return day; 
    }
    public int getMonth(){
       return day; 
    }
    public int getYear(){
       return year; 
    }
    
    public void setDate(int day, int month, int year){
        this.day = day;
        this.month = month;
        this.year = year;
    }
    
    public override string ToString(){
        return day.ToString() + "/" + month.ToString() + "/" + year.ToString();
    }
    
    public static bool validateDate(SimpleDate date){
        return false;
    }   
}

public class Address
{
    public string area;
    public string city;
    
    public Address(string area, string city){
        this.area = area;
        this.city = city;
    }
    
    public string getArea(){
        return area;
    }
    public string getCity(){
        return city;
    }
    
    public void setArea(string area){
        this.area = area;
    }
    
    public void setCity(string city){
        this.city = city;
    }
    
    public override string ToString(){
        return area + ", " +city;
    }
}

public class Customer
{
    public int custId;
    public string name;
    public Address address;
    public SimpleDate registrationDate;
    
    public Customer(int custId, string name, Address address, SimpleDate registrationDate){
        this.custId = custId;
        this.name = name;
        this.address = address;
        this.registrationDate = registrationDate;
    }
    
    public Address getAddress(){
        return address;
    }
    
    public SimpleDate getRegistrationDate(){
        return registrationDate;
    }
    
    public override string ToString(){
        return "Id :" + custId +", Name :" + name + "\n" +"Address :" + getAddress() + "\n" + "Registered on:" + getRegistrationDate();
    }
}

public class CustomerInformation
{
    void GetCustomer()
    {
        int custId = Convert.ToInt32(Console.ReadLine());
        string name = Console.ReadLine();
        string area = Console.ReadLine();
        string city = Console.ReadLine();
        int day = Convert.ToInt32(Console.ReadLine());
        int month = Convert.ToInt32(Console.ReadLine());
        int year = Convert.ToInt32(Console.ReadLine());
       
        SimpleDate simpleDate = new SimpleDate(day, month, year);
        Address address = new Address(area, city);
        Customer customer = new Customer(custId, name, address, simpleDate);
        Console.WriteLine(customer);
        
    }
}