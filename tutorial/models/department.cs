using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.models
{
    public class department
    {
        public string dept_no { get; set; }
        public string dept_name { get; set; }
        public string location { get; set; }
        public department()
        {
            dept_no = string.Empty;
            dept_name = string.Empty;
            location = string.Empty;
        }
    }
}
