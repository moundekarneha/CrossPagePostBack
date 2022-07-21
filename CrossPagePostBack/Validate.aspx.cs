using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrossPagePostBack
{
    public partial class Validate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Form["username"];
            string password = Request.Form["pass"];
            if (name == "admin" && password == "admin")
                Response.Write("valid user");
            else
                Response.Write("invalid user");

            //if (!IsPostBack)
            //    username.Focus();
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            //username.Text = "";
            //pass.Text = "";
        }
    }
}