using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrossPagePostBack
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                username.Focus();
        } 

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && pass.Text == "admin")
                Response.Write("Logged in");
                
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            username.Text = "";
            pass.Text = "";
        }
    }
}