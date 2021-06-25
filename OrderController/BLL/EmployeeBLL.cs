using OrderController.DAL;
using OrderController.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OrderController.BLL
{
    class EmployeeBLL
    {
        public static List<Employee> getListAllEmployee()
        {
            List<Employee> employees = new List<Employee>();
            DataTable dataTable = EmployeeDAL.getDataTableAllEmployee();
            foreach (DataRow row in dataTable.Rows)
            {
                employees.Add(new Employee(Int32.Parse(row["EmployeeID"].ToString()), row["EmployeeName"].ToString()));
            }
            return employees;
        }
    }
}
