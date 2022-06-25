using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace EmployeePayrollService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Pay Roll Services");
            EmployeePayrollServices employeePayrollService = new EmployeePayrollServices(); 
            EmployeeModel employeeModel = new EmployeeModel();
            employeePayrollService.GetEmployee();
            
           
               
            
        }

    }
}
