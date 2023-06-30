using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UI.Controllers
{
    class SubCateogryController:ControllerBase
    {
        public DataTable GetSubCategoryWithCategoryID(string spName,string categoryID)
        {
            command = new SqlCommand(spName, connection, Transaction);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Action", SqlDbType.Char).Value = 8;
            command.Parameters.Add("@CategoryID", SqlDbType.Char).Value = categoryID;
            var adapter = new SqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
