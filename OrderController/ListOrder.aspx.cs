using OrderController.BLL;
using OrderController.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderController
{
    public partial class ListOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                loadDataToCustomerDDL();
                loadDataToEmployeeDDL();
                FromTB.Text = "1-1-1800";
                ToTB.Text = DateTime.Now.ToString("MM-dd-yyyy");
                loadDataToDataGridOrder();
            }
           
        }
        private void loadDataToCustomerDDL()
        {
            List<Customer> listCustomer = CustomerBLL.getListAllCustomer();
            CustomerDDL.Items.Add(new ListItem("All Customer", "all"));
            foreach(Customer customer in listCustomer)
            {
                CustomerDDL.Items.Add(new ListItem(customer.CompanyName,customer.CustomerID));
            }
        }
        private void loadDataToEmployeeDDL()
        {
            List<Employee> listEmp = EmployeeBLL.getListAllEmployee();
            EmployeeDDL.Items.Add(new ListItem("All Employee", "-1"));
            foreach(Employee emp in listEmp)
            {
                EmployeeDDL.Items.Add(new ListItem(emp.EmployeeName, emp.EmployeeID.ToString()));
            }
        }
        private void loadDataToDataGridOrder()
        {
            List<Order> listOder = OrderBLL.getListOrderWithConditions(CustomerDDL.SelectedValue, EmployeeDDL.SelectedValue, DateTime.Parse(FromTB.Text), DateTime.Parse(ToTB.Text), LateOrderCheck.Checked);
            GridViewOrder.DataSource = listOder;
            DataBind();
        }

        protected void FromPickDateBT_Click(object sender, EventArgs e)
        {
            if(FromCelendar.Visible)
            {
                FromCelendar.Visible = false;
            }
            else
            {
                FromCelendar.Visible = true;
            }
        }
        protected void ToPickDateBT_Click(object sender, EventArgs e)
        {
            if (ToCalendar.Visible)
            {
                ToCalendar.Visible = false;
            }
            else
            {
                ToCalendar.Visible = true;
            }
        }

        protected void FromCelendar_SelectionChanged(object sender, EventArgs e)
        {
            if (FromCelendar.SelectedDate < DateTime.Now)
            {
                FromTB.Text = FromCelendar.SelectedDate.ToString("MM-dd-yyyy");
                FromCelendar.Visible = false;
                loadDataToDataGridOrder();
            }

        }

        protected void ToCalendar_SelectionChanged(object sender, EventArgs e)
        {
            DateTime fromDate;
            DateTime.TryParse(FromTB.Text,out fromDate);
            if (ToCalendar.SelectedDate < DateTime.Now && ToCalendar.SelectedDate > fromDate)
                {
                    ToTB.Text = ToCalendar.SelectedDate.ToString("MM-dd-yyyy");
                    ToCalendar.Visible = false;
                    loadDataToDataGridOrder();
                }
            
        }

        protected void LateOrderCheck_CheckedChanged(object sender, EventArgs e)
        {
            loadDataToDataGridOrder();
        }

    }
}