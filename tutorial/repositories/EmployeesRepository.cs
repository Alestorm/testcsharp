using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tutorial.viewmodels;

namespace tutorial.repositories
{
    public interface EmployeesRepository
    {
        List<EmployeeViewmodel> GetEmployeeProjects();
    }
}
