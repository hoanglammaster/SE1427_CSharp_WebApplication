﻿using OrderController.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace OrderController.DAL
{
    class ProductDAL
    {
        public static DataTable getDataTableAllProduct()
        {
            string query = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock FROM Products";
            SqlCommand command = new SqlCommand(query, DAO.getConnection());
            return DAO.getTableFromSql(command);
        }
        public static void reduceUnitInStockOfProduct(List<Product> products)
        {
            List<string> dbOperations = new List<string>();
            foreach (Product product in products)
            {
                dbOperations.Add("UPDATE Products SET UnitsInStock = UnitsInStock - " + product.Quantity + " , UnitsOnOrder = UnitsOnOrder + " + product.Quantity + " WHERE ProductID = " + product.ProductID);
            }
            DAO.runBatchSql(dbOperations);
        }
    }
}
