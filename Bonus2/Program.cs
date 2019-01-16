using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int year, month, day;
            
            Console.WriteLine("User what is your name?");
            name = Console.ReadLine();


            DateTime birthdate, today;
            TimeSpan userAge;
            int userDays, currentAge;
            double Birthday;
            Console.WriteLine(name + " when were you born?(enter MM/DD/YYYY)");
            birthdate = Convert.ToDateTime(Console.ReadLine());

            today = DateTime.Now;
            userAge = today.Subtract(birthdate);
            userDays = userAge.Days;
            currentAge = (userDays / 365);
            Console.WriteLine(name + " you are " + currentAge + " years old.");
            Birthday = userAge.TotalDays;
            if (birthdate.DayOfYear == today.DayOfYear)
            {
                Console.WriteLine("Happy Birthday today!");
            }
            
                                 





            Console.ReadLine();






            //figure out how to use the c# libary current date
            //do a lay out similar to the C# libary current date to calucalte the age o the person
            //wish them happy birthday if C# libary current date = date entered
        }
    }
}
