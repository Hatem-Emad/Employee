using System;

namespace Day05
{
    enum Gender
    {
        Male,Female
    }

    enum SecurityLevel
    {
        Guest, Secretary, Developer, DBA
    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of the employees");
            int n = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[n];
            for(int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                employees[i].Id = employees[i].checkId(i);
                employees[i].Name = employees[i].checkName();
                employees[i].Salary = employees[i].checkSalary();
                employees[i].Security = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), employees[i].checkSecurity());
                employees[i].Gender= (Gender)Enum.Parse (typeof(Gender), employees[i].checkGender());
                Console.WriteLine("Please enter the hiring date in this format dd,mm,yy");
                employees[i].setStrHireDate(Console.ReadLine());
                employees[i].showInfo();
                Console.WriteLine("##############################################");


            }
            //Employee emp1 = new Employee();
            //emp1.Id= 1;
            //emp1.Name = "asd";
            //emp1.Salary = 12344;
            //emp1.Gender = Gender.Male;
            //emp1.Security = SecurityLevel.Guest;
            //emp1.Hire = emp1.Hire;
            //emp1.showInfo();
        }
    }
}
