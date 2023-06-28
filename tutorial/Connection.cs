using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    public class Connection
    {
        public static string DbConnection(string server, string db, string user, string password, string name)
        {
            string connection = string.Empty;
            try
            {
                connection = "Persist Security Info=True;User ID=" + user + ";Pwd=" + password + ";Server=" + server + ";Database=" + db + ";Application Name =" + name;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return connection;
        }
    }
}
