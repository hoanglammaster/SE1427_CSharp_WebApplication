﻿using OrderWebsite.BLL;
using OrderWebsite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderWebsite
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderBLL orderBLL = new OrderBLL();
            List<Order> orders =  orderBLL.getListAllOrder();
            DropDownList1.DataSource = orders;
            DropDownList1.DataTextField = "OrderID";
            DropDownList1.DataValueField = "OrderID";
            DropDownList1.DataBind();
            GridView1.DataSource = orders;
            GridView1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("WebForm2.aspx");
        }
    }
}