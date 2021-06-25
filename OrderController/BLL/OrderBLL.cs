using OrderController.DAL;
using OrderController.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;

namespace OrderController.BLL
{
    public class OrderBLL
    {
        public static List<Order> getListAllOrder()
        {
            return convertDataTabelToList(OrderDAL.getDataTabelAllOrder());
        }
        public static List<Order> getListOrderWithConditions(string customerId, string employeeId, DateTime from, DateTime to, bool lateOrder)
        {
            //Convert "All Customer" to "%" because "%" mean non-condition in sql
            if (customerId.Equals("all"))
            {
                customerId = "%";
            }
            if(employeeId.Equals("-1"))
            {
                employeeId = "%";
            }
            
            return convertDataTabelToList(OrderDAL.getDataTableOrderWithConditions(customerId,employeeId,from,to,lateOrder));
        }
        public static void insertOrderToDB(string cusID, int empID, DateTime req, int via, double freight, List<Product> products)
        {
            string pattern = "MM-dd-yyyy";
            DateTime order = DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy"));
            int orderID = OrderDAL.insertOrderToDB(cusID, empID, order, req, via, freight);
            OrderDAL.insertOrderDetailsToDB(products, orderID);
            ProductDAL.reduceUnitInStockOfProduct(products);
            
        }
        //convert DataTable to List<Order>
        private static List<Order> convertDataTabelToList(DataTable orderTabel)
        {
            List<Order> listOrder = new List<Order>();
            foreach (DataRow dataRow in orderTabel.Rows)
            {
                DateTime shippedDate;
                DateTime.TryParse(dataRow["ShippedDate"].ToString(), out shippedDate);
                listOrder.Add(new Order(Int32.Parse(dataRow["OrderID"].ToString()),
                dataRow["Customer"].ToString(),
                dataRow["Employee"].ToString(),
                DateTime.Parse(dataRow["OrderDate"].ToString()),
                DateTime.Parse(dataRow["RequiredDate"].ToString()),
                shippedDate,
                Decimal.Parse(dataRow["Freight"].ToString())));
            }
            return listOrder;
        }
    }
}
