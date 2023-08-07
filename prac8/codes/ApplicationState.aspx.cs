using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Practical_8
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["name"] = TextBox1.Text;
            Application["age"] = TextBox2.Text;
            Application["branch"] = TextBox3.Text;
            Response.Redirect("AS2.aspx");
        }
    }
}