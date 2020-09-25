/*Complete the implementation of Main() to get below output



Sample Output :

Employee Details are

EmpId is = 100

Emp Name is = AAA

Emp Salary is = 12345

Emp Bonus is = 3000

Emp Role is = Leader

Note : Create object of the SalesManagement class in the Main() and initialize all necessary variables with the help of member functions defined inside the class.The program doesnot take any input data .Argument for all member functions is hard coded in the program to get the required output

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExersice
{
    class Program
    {

        static void Main(string[] args)
        {
            SalesManagement sm = new SalesManagement();
            sm.setEmpId(100);
            sm.setName("AAA");
            sm.setSalary(12345);
            sm.setBonus(3000);
            sm.setRole("Leader");
            
            Console.WriteLine("Employee Details are");
            Console.WriteLine("EmpId is = " +sm.getEmpId());
            Console.WriteLine("Emp Name is = " +sm.getName());
            Console.WriteLine("Emp Salary is = " +sm.getSalary());
            Console.WriteLine("Emp Bonus is = " +sm.getBonus());
            Console.WriteLine("Emp Role is = " +sm.getRole());
        }
    }

    public class Employee
    {
        public int empId;
        public String name;
        public float salary;
        public Address a;

        public int getEmpId()
        {
            return empId;
        }
        public void setEmpId(int empId)
        {
            this.empId = empId;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public float getSalary()
        {
            return salary;
        }
        public void setSalary(float salary)
        {
            this.salary = salary;
        }
        public Address getA()
        {
            return a;
        }
        public void setA(Address a)
        {
            this.a = a;
        }




    }

    class Sales : Employee
    {
	
float bonus;

public float getBonus()
    {
        return bonus;
    }

    public void setBonus(float bonus)
    {
        this.bonus = bonus;
    }

}

class SalesManagement : Sales
{
    String role;

public String getRole()
{
    return role;
}

public void setRole(String role)
{
    this.role = role;
}	

}

class Engineering : Employee
{
    String designation;

public String getDesignation()
{
    return designation;
}

public void setDesignation(String designation)
{
    this.designation = designation;
}

}

public class Address
{
    protected String streetName = "xx";
    protected String cityName = "cc";
    public String getStreetName()
    {
        return streetName;
    }
    public void setStreetName(String streetName)
    {
        this.streetName = streetName;
    }
    public String getCityName()
    {
        return cityName;
    }
    public void setCityName(String cityName)
    {
        this.cityName = cityName;
    }

}

   

}

