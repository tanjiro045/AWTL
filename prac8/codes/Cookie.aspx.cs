using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Practical_8
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie userInfo = new HttpCookie("userInfo");
            userInfo["name"] = TextBox1.Text;
            userInfo["age"] = TextBox2.Text;
            userInfo["branch"] = TextBox3.Text;
            Response.Cookies.Add(userInfo);
            Response.Redirect("Cookie2.aspx");

        }
    }
}