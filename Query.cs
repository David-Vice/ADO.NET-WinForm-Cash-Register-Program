using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADO.NET_WinForm_HW1
{
    public static class Query
    {
        public static DataTable Show(string query)
        {
            DataTable data = new DataTable();

            SqlCommand command = new SqlCommand(query, Main.connection);

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(data);
            }

            return data;
        }
    }
}
