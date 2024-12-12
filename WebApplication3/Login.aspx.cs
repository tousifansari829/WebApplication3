using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = TextBox1.Text; 
            string pass = TextBox2.Text;   
            if (user.Equals(pass))
            {


                Session["Username"] = user;
                Response.Redirect("AddProduct.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Username and Password!') </script>");
            }
        }
    }
}