using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_5
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = null;
                string connectionstring = "Data Source=LAPTOP-LABV26J8;Initial Catalog=MCA;Integrated Security=True";
                conn = new SqlConnection(connectionstring);
                {
                    SqlCommand query = new SqlCommand("SELECT * FROM EMP",conn);
                    conn.Open();
                    SqlDataReader rdr = query.ExecuteReader();
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}