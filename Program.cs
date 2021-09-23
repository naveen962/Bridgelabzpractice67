using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Fulltime = 1;
            const int Parttime = 0;
            int Emp_Wage_Per_Hour = 20;
            int Emp_Hours = 0;
            Random ran = new Random();
            int Empcheck=ran.Next(0, 2);
          switch (Empcheck)
            {
                case Fulltime:
                    Emp_Hours = 8;
                    break;

                case Parttime:
                    Emp_Hours = 4;
                    break;
                default:
                    Console.WriteLine("ABSENT");
                    break;

            }

            int EmployeeWage = Emp_Hours* Emp_Wage_Per_Hour;
            Console.WriteLine("EMPLOYEE WAGES =" + EmployeeWage);
        }
    }
}
