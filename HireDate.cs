using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal struct HireDate
    {
        int day;
        int month;
        int year;

        public static int checkDay()
        {
            int day;
            do
            {
                Console.WriteLine("Please enter the day of hirement");
            } while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 30);
            return day;
        }

        public static int checkMonth()
        {
            int month;
            do
            {
                Console.WriteLine("Please enter the month of hirement");
            } while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12);
            return month;
        }

        public static int checkYear()
        {
            int year;
            do
            {
                Console.WriteLine("Please enter the year of hirement");
            } while (!int.TryParse(Console.ReadLine(), out year) || year < 2000 || year > 2023);
            return year;
        }
        public HireDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day { get { return day; } set { day = value; } }
        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }

        public string showDate()
        {
            return $"Day: {Day} Month: {Month} Year: {Year}";   
        }

        
    }

}
