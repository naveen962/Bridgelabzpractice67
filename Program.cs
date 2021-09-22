using System;

namespace EmployeeCheck
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Random object created
            Random ran = new Random();
            int EmpCheck = ran.Next(0, 2);
            int Fulltime = 1;
            //condition
            if (EmpCheck == Fulltime)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }
        }
    }
}
