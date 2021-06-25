using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OrderController.DAL
{
    class CustomerDAL
    {
        public static DataTable getDataTabelAllCustomer()
        {
            string query = "SELECT CustomerID, CompanyName FROM Customers";
            SqlCommand command = new SqlCommand(query,DAO.getConnection());
            return DAO.getTableFromSql(command);
        }
    }
}
