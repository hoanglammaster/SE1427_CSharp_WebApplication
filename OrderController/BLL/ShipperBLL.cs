using OrderController.DAL;
using OrderController.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OrderController.BLL
{
    class ShipperBLL
    {
        public static List<Shipper> getListAllShipper()
        {
            List<Shipper> shippers = new List<Shipper>();
            DataTable dataTable = ShipperDAL.getDataTableAllShipper();
            foreach(DataRow row in dataTable.Rows)
            {
                shippers.Add(new Shipper(Int32.Parse(row["ShipperID"].ToString()),row["CompanyName"].ToString()));
            }
            return shippers;
        }
    }
}
