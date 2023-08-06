using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_6
{
    public partial class Practical6b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = null;
                string connstring = "Data Source=LAPTOP-LABV26J8;Initial Catalog=MCA;Integrated Security=True";
                con = new SqlConnection(connstring);
                con.Open();
                SqlCommand cmd = new SqlCommand("SUNNYPROCEDURE", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();

            }
            catch(Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}