using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_8
{
    public partial class SM2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
            {
                Label1.Text = Session["name"].ToString();
            }
            if (Session["age"] != null)
            {
                Label2.Text = Session["age"].ToString();
            }
            if (Session["branch"] != null)
            {
                Label3.Text = Session["branch"].ToString();
            }

        }
    }
}