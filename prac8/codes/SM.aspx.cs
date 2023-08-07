using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_8
{
    public partial class SM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["age"] = TextBox2.Text;
            Session["branch"] = TextBox3.Text;
            Response.Redirect("SM2.aspx");
        }
    }
}