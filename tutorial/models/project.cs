using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial.models
{
    public class project
    {
        public string project_no { get; set; }
        public string project_name { get; set; }
        public decimal budget { get; set; }

        public project()
        {
            project_no = string.Empty;
            project_name = string.Empty;
            budget = 0;
        }
    }
}
