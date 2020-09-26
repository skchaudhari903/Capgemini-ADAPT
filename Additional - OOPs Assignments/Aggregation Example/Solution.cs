/*Complete the implementation of Main() to get below output



Sample Output :

Employee Details are

EmpId is = 100

Emp Name is = AAA

Emp Salary is = 12345

Emp Bonus is = 3000

Emp streetName is = xxx

Emp streetName is = Bangalore



Note : Create object of the Sales class in the Main() and initialize all necessary variables with the help of member functions defined inside the class.The program doesnot take any input data .Argument for all member functions is hard coded in the program to get the required output

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
            Sales s = new Sales();
            s.setEmpId(100);
            s.setName("AAA");
            s.setSalary(12345);
            s.setBonus(3000);
            Address add = new Address();
            add.setStreetName("xxx");
            add.setCityName("Bangalore");
            //s.setA(add);
            
            Console.WriteLine("Employee Details are");
            Console.WriteLine("EmpId is = " +s.getEmpId());
            Console.WriteLine("Emp Name is = " +s.getName());
            Console.WriteLine("Emp Salary is = " +s.getSalary());
            Console.WriteLine("Emp Bonus is = " +s.getBonus());
            Console.WriteLine("Emp streetName is = " +add.getStreetName());
            Console.WriteLine("Emp streetName is = "+add.getCityName());
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

