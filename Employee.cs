using System;

class Employee{
  //fields
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;
  private double percent;

//properties
  public string FirstName{get;set;}
  public string LastName{get;set;}
  public string Id{get;set;}
  public string EmploymentStatus{get;set;}

  public int Age{
    get {return age;}
    set{
      if (value >= 18){
        age=value;
      }
      else{
        age=18;
        Console.WriteLine("Under 18 years old.");
      }
    }
  }

  public double YearlySalary{
    get {return yearlysalary;}
    set{
      if (value >= 1000){
        yearlysalary=value;
      }
      else{
        Console.WriteLine("Yearly Salary: Under $1000.");
      }
    }
  }
  public double Percent{
get {return percent;}
set{
  if (value >0){
    percent =value;
  }
  else{
    Console.WriteLine("Invalid Salary, Yearly salary not updated.");
  }
}
  }
  public Employee()
  {
    FirstName ="unknown";
    LastName ="unknown";
    Id = "unknown";
    EmploymentStatus= "unknown";

  }
  public Employee(string empfirstname, string emplastname, string empid, int empage, string empemploymentstatus)
{
  FirstName= empfirstname;
  LastName = emplastname;
  Id = empid;
  Age = empage;
  EmploymentStatus= empemploymentstatus;
}  
//methods
public void Intro()
{
   Console.WriteLine("My first name is " + FirstName);
    Console.WriteLine("My last name is " + LastName);
     Console.WriteLine("My id is " + Id);
      Console.WriteLine("My age is " + Age);
      
}
public double IncreaseSalary()
{
   double total = IncreaseSalary();
    Console.WriteLine("Yearly Salary updated to $" +  total +("."));
  return ( Percent * YearlySalary);
}

public void RemoveEmployee()
{

  if (EmploymentStatus == "inactive")
  Console.WriteLine("Employee removed successfully, employee inactive.");
  else if (EmploymentStatus == "active")
  {
    EmploymentStatus = "inactive";
  Console.WriteLine("Employee removed successfully, emplpoyee inactive.");
  }
 
}
 

}