using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.models
{
    public class employee
    {
        public string emp_no { get; set; }
        public string emp_fname { get; set; }
        public string emp_lname { get; set; }
        public string dept_no { get; set; }

        public employee()
        {
            emp_no = string.Empty;
            emp_fname = string.Empty;
            emp_lname = string.Empty;
            dept_no = string.Empty;

        }
    }
}
