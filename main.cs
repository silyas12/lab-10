using System;

class Program {
  public static void Main (string[] args) {

    Employee unknown = new Employee();
    unknown.Intro();

 Employee Robert = new Employee("Robert", "Downey", "12321",12,"inactive");
 Robert.Intro();
 Robert.YearlySalary = 100;
 
Employee John = new Employee("John","Smith", "S0089", 38, "inactive");
John.Intro();
John.YearlySalary = 50000;
John.Percent = -2;
John.RemoveEmployee();


Employee Maria = new Employee("Maria","Lambert","S0100",26,"active");
 Maria.Intro();
 Maria.YearlySalary = 80000;
 Maria.Percent = 7;
 Maria.RemoveEmployee();
    
  }
}