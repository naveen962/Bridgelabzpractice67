using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
				//declaring variables
            int Fulltime = 1;
            int Emp_Wage_Per_Hour = 20;
            int Emp_Hours = 0;
				//object created
            Random ran = new Random();
            int Empcheck=ran.Next(0, 2);
				//condition
            if (Empcheck==Fulltime)
            {
                Emp_Hours = 8;
            }
            else
            {
                Emp_Hours = 0;
            }

            int EmployeeWage = Emp_Hours* Emp_Wage_Per_Hour;
            Console.WriteLine("EMPLOYEE WAGES =" + EmployeeWage);
        }
    }
}
