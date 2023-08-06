using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical7New
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBox1.Text);
            DataClasses1DataContext dbCon = new DataClasses1DataContext("Data Source=LAPTOP-LABV26J8;Initial Catalog=MCA;Integrated Security=True");
            GridView1.DataSource = (from stud in dbCon.STUDENTs where stud.ID == id select stud);
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dbCon = new DataClasses1DataContext("Data Source=LAPTOP-LABV26J8;Initial Catalog=MCA;Integrated Security=True");
            GridView1.DataSource = (from row in dbCon.STUDENTs select row);
            GridView1.DataBind();
        }
    }
}