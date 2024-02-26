using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery
{
    internal class BaglantıAcma
    {
        public SqlConnection BaglantiAc()
        {
            string connection = " Server = DESKTOP-TQ8FN5C\\SQLDERS; Database=Bakery;User Id=sa;Password=1;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            return con;

        }
        public void BaglantiKapat(SqlConnection con)
        {
            con.Close();
        }
        
    }
}
