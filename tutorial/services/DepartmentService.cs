using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tutorial.models;
using tutorial.repositories;
using tutorial.viewmodels;

namespace tutorial.services
{
    public class DepartmentService : IDepartmentRepository
    {
        string connectionString = Connection.DbConnection("DESKTOP-11923P8", "companyV1", "sa", "93639", "");
        public List<department> GetAll()
        {
            List<department> departments = new List<department>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetDepartements", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            department department = new department();
                            department.dept_no = reader.GetString(0);
                            department.dept_name = reader.GetString(1);
                            department.location = reader.GetString(2);

                            departments.Add(department);
                        }
                    }
                }
            }
            return departments;
        }
    }
}
