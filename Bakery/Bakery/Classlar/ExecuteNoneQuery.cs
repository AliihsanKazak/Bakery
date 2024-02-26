using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class ExecuteNoneQuery
    {
        public void Execute(string query, SqlConnection con)
        {
            SqlCommand command = new SqlCommand(query, con);

            command.ExecuteNonQuery();
        }
    }
}
