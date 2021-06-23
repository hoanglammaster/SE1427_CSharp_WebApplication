using OrderWebsite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderWebsite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.PreviousPage != null)
            {
                GridView gridView = (GridView)Page.PreviousPage.FindControl("GridView1");
                if(gridView != null)
                {
                    GridView1.DataSource = gridView.DataSource;
                }
            }
            DataBind();
        }
    }
}