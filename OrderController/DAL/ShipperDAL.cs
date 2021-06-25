using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OrderController.DAL
{
    class ShipperDAL
    {
        public static DataTable getDataTableAllShipper()
        {
            string query = "SELECT ShipperID, CompanyName FROM Shippers";
            SqlCommand command = new SqlCommand(query, DAO.getConnection());
            return DAO.getTableFromSql(command);
        }
    }
}
