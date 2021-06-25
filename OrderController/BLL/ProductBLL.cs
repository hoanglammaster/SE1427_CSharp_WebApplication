using OrderController.DAL;
using OrderController.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OrderController.BLL
{
    class ProductBLL
    {
        public static List<Product> getListAllProduct()
        {
            List<Product> products = new List<Product>();
            DataTable dataTable = ProductDAL.getDataTableAllProduct();
            foreach (DataRow row in dataTable.Rows)
            {
                products.Add(new Product(Int32.Parse(row["ProductID"].ToString()), row["ProductName"].ToString(), row["QuantityPerUnit"].ToString(), Decimal.Parse(row["UnitPrice"].ToString()), Int32.Parse(row["UnitsInStock"].ToString())));
            }
            return products;
        }
       
    }
}
