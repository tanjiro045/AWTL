using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_9a
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebService1 service1 = new WebService1();
            DataSet dataSet = service1.getStudents();
            GridView1.DataSource = dataSet;
            GridView1.DataBind();

        }
    }
}