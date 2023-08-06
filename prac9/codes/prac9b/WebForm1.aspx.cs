using Practical_9b.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_9b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1Client service1Client = new Service1Client();
            DataSet ds = service1Client.getEmployees();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}