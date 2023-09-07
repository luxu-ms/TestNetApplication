using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = Request.QueryString["TextBox1"];
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?TextBox1=" + TextBox1.Text);
        }
    }
}