using OrderController.DAL;
using OrderController.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OrderController.BLL
{
    class CustomerBLL
    {
        public static List<Customer> getListAllCustomer()
        {
            List<Customer> customers = new List<Customer>();
            DataTable dataTable = CustomerDAL.getDataTabelAllCustomer();
            foreach(DataRow row in dataTable.Rows)
            {
                customers.Add(new Customer(row["CustomerID"].ToString(), row["CompanyName"].ToString()));
            }
            return customers;
        }
    }
}
