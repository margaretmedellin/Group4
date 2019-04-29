using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PerfectMatch
{
    public class SqlConnect
    {
        public SqlConnection Con { get; set; }
        public string conString { get; set; }

    }

}
