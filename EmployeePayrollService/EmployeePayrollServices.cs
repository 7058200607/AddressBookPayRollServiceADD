using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    public class EmployeePayrollServices
    {
         //connection with Data base
            public static string connectionstring = ("data source= LAPTOP-BIDRJU4B;Initial catalog= Employee;integrated security=true");
        //sql connection to database
        SqlConnection connection = new SqlConnection(connectionstring); 
        public void GetEmployee()
        {
            try
            {
                EmployeeModel empPayrollService = new EmployeeModel();
                using (this.connection)
                {
                    string query = @"select empid,empname,salary,start_date,gender,phoneNumber,departement,address,;";
                    //define sql object
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    SqlDataReader dr = cmd.ExecuteReader();
                    //check if there are records
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            empPayrollService.empid = dr.GetInt32(0);
                            empPayrollService.empname = dr.GetString(1);
                            empPayrollService.salary = dr.GetString(2);
                            empPayrollService.start_date = dr.GetString(3);
                            empPayrollService.gender = dr.GetString(4);
                            empPayrollService.phoneNumber = dr.GetString(5);
                            empPayrollService.departement = dr.GetString(6);
                            empPayrollService.address = dr.GetString(7);
                            //to display retrive record
                            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", empPayrollService.empid, empPayrollService.empname, empPayrollService.salary, empPayrollService.start_date, empPayrollService.gender, empPayrollService.phoneNumber,empPayrollService.departement,empPayrollService.address);
                            Console.WriteLine("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Data Found");

                    }
                    //close connection
                    dr.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);

            }
            finally 
            {
                this.connection.Close();
            }

        }
    }
}

