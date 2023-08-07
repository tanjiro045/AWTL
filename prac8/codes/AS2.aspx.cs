using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Practical_8
{
    public partial class AS2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["name"] != null)
            {
                Label1.Text = Application["name"].ToString();
            }
            if (Application["age"] != null)
            {
                Label2.Text = Application["age"].ToString();
            }
            if (Application["branch"] != null)
            {
                Label3.Text = Application["branch"].ToString();
            }
        }
    }
}