using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageAbstract
{
    public abstract class Employee
    {
        public abstract void EmployeeWage();
        public int EmpPresent = 1;
        public int FullTime = 1;
        public int Wage_Per_Hour = 20;
        public int Full_Day_Hour = 8;
        public int PartTime_Day_Hour = 4;
        public int wage = 0;

    }

    public class Wage : Employee
    {
        public override void EmployeeWage()
        {
            Random EmpCheck = new Random();
            int value = EmpCheck.Next(0, 2);

            if (value == EmpPresent)
            {
                Random TimeCheck = new Random();
                int WorkingHours = TimeCheck.Next(0, 2);
                if (WorkingHours == FullTime)
                {
                    wage = Wage_Per_Hour * Full_Day_Hour;
                    Console.WriteLine("Employee Full Time Wage is = " + wage);
                }

                else
                {
                    wage = Wage_Per_Hour * PartTime_Day_Hour;
                    Console.WriteLine("Employee Part Time Wage is = " + wage);
                }

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Employee Daily Wage is = 0");
            }
            
        }
    }

    
        
        
            
        

       

    
}
