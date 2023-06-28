using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tutorial.repositories;
using tutorial.viewmodels;
using tutorial.models;

namespace tutorial.services
{
    public class EmployeeService : EmployeesRepository
    {
        string connectionString = Connection.DbConnection("DESKTOP-11923P8", "companyV1", "sa", "93639", "");
        public List<EmployeeViewmodel> GetEmployeeProjects()
        {
            List<EmployeeViewmodel> employees = new List<EmployeeViewmodel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetEmployeeProjects", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeViewmodel employee = new EmployeeViewmodel();
                            employee.Employee.emp_fname = reader.GetString(0);
                            employee.Employee.emp_lname = reader.GetString(1);
                            employee.Project.project_name = reader.GetString(2);
                            employee.Works_On.job = reader.GetString(3);
                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }
    }
}
