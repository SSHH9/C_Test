using System;

namespace _230204Assignment2_228
{
    class Program
    {
        static void calc_monthly_salary(int annual_salary)
        {
            double tmp = annual_salary / 12;

            double result = Math.Truncate(tmp);

            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            calc_monthly_salary(12000000);
        }
    }
}
