using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.models
{
    public class works_on
    {
        public string emp_no { get; set; }
        public string project_no { get; set; }
        public string job { get; set; }
        public DateTime enter_date { get; set; }

        public works_on()
        {
            emp_no = string.Empty;
            project_no = string.Empty;
            job = string.Empty;
            enter_date = DateTime.Now;
        }
    }
}
