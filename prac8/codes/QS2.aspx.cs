using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Practical_8
{
    public partial class QS2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string names = Request.QueryString["name"];
            string ages = Request.QueryString["age"];
            string branches = Request.QueryString["branch"];

            Label1.Text = names;
            Label2.Text = ages;
            Label3.Text = branches;
        }
    }
}