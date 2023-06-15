using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class EmployeeDisconnected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = null;
                string connstring = "Data Source=LAPTOP-LABV26J8;Initial Catalog=MCA;Integrated Security=True";
                conn = new SqlConnection(connstring);
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM EMP", conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}