using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Employee
    {
        int id;
        string name;
        int salary;
        Gender gender;
        SecurityLevel security;
        StrHireDate strHire;
        //HireDate hire;


        public int checkId(int i)
        {
            int id;
            do
            {
                Console.WriteLine($"Please enter the Id of employee {i+1}");
            }while(!int.TryParse(Console.ReadLine(), out id));
            return id;
        }
        public string checkName()
        {
            string name;
            do
            {
                Console.WriteLine("Please insert the name");
                name = Console.ReadLine(); //how to get real string
            } while (name.GetType() != typeof(string));
            return name;
        }
        public int checkSalary()
        {
            int sal;
            do
            {
                Console.WriteLine("Please enter salary 10,000+");
            } while ( (!int.TryParse(Console.ReadLine(), out sal)) || (sal < 10000));
            return sal;
        }
        public string checkSecurity()
        {
            string sec;
            do
            {
                Console.WriteLine("Please enter security, type one of the following");
                Console.WriteLine("-Guest \n-Developer \n-Secretary \n-DBA");
                sec = Console.ReadLine();
            } while (!Enum.IsDefined(typeof(SecurityLevel), sec));
            return sec;
        }
        public string checkGender()
        {
            string gen;
            do
            {
                Console.WriteLine("Please enter the gender: \n-Male \n-Female");
                gen = Console.ReadLine();
            } while (gen != "Male" && gen != "Female");
            return gen;
        }

       
        //public Employee(int id, string name, int salary, Gender gender, SecurityLevel security, HireDate hire)
        //{
        //    this.id = id;
        //    this.name = name;
        //    this.salary = salary;
        //    this.gender = gender;
        //    this.security = security;
        //    this.hire = hire;
        //}

        public void showInfo()
        {
            Console.WriteLine($"\nId: {Id} Name: {Name} Salary: {Salary} Gender: {Gender} " +
                $"SecurityLevel: {Security} HireDate: {getHireDate()}" );
        }
       
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public SecurityLevel Security { get; set; }
        public Gender Gender { get; set; }

        //public void setHireDate(int day, int month, int year)
        //{
        //    hire.Day = day;
        //    hire.Month = month;
        //    hire.Year = year;
        //}
        public void setStrHireDate(string date)
        {
            string[] StrDate = date.Split(',');
            strHire.Day = StrDate[0];
            strHire.Month = StrDate[1];
            strHire.Year = StrDate[2];

        }

        public string getHireDate() { return strHire.showDate(); }
    }
    
        
}
