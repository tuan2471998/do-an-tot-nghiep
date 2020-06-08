using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Da
{
    public class connect
    {
         public SqlConnection cnn = new SqlConnection();

        public connect()
        {
           
            cnn = new SqlConnection(@"Data Source=LAPTOP-L7M0ONU5;Initial Catalog=QL_KHACHSAN;Integrated Security=True");
            if(cnn.State == System.Data.ConnectionState.Closed)
            cnn.Open();

        }

    }
}
