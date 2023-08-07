using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Practical_8
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            TextBox1.Text = "";
            ViewState["age"] = TextBox2.Text;
            TextBox2.Text = "";
            ViewState["branch"] = TextBox3.Text;
            TextBox3.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["name"].ToString();
            TextBox2.Text = ViewState["age"].ToString();
            TextBox3.Text = ViewState["branch"].ToString();
        }
    }
}