using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tutorial.models;

namespace tutorial.repositories
{
    public interface IDepartmentRepository
    {
        List<department> GetAll();
        string AddDepartment(department department);
    }
}
