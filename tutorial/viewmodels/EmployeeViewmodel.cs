using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tutorial.models;

namespace tutorial.viewmodels
{
    public class EmployeeViewmodel
    {
        public employee Employee { get; set; }
        public project Project { get; set; }
        public works_on Works_On { get; set; }
        public EmployeeViewmodel()
        {
            Employee = new employee();
            Project = new project();
            Works_On = new works_on();
        }

    }
}
