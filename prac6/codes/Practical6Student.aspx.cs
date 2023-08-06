using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_6
{
    public partial class Practical6Student : System.Web.UI.Page
    {

        SqlConnection con = null;
        string cs  = "Data Source=LAPTOP-LABV26J8;Initial Catalog=MCA;Integrated Security=True";
        SqlCommand cmd = new SqlCommand();
        SqlParameter sp1, sp2, sp3, sp4;

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            cmd = new SqlCommand("SunnyParamProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            sp1 = new SqlParameter("@ID", SqlDbType.Int);
            sp2 = new SqlParameter("@NAME", SqlDbType.NVarChar);
            sp3 = new SqlParameter("@DEGREE", SqlDbType.NVarChar);
            sp4 = new SqlParameter("@SUBJECT", SqlDbType.NVarChar);
            sp1.Value = Convert.ToInt32(TextBox1.Text);
            sp2.Value = TextBox2.Text;
            sp3.Value = TextBox3.Text;
            sp4.Value = TextBox4.Text;
            cmd.Parameters.Add(sp1);
            cmd.Parameters.Add(sp2);
            cmd.Parameters.Add(sp3);
            cmd.Parameters.Add(sp4);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Label1.Text = "Successfully inserted!";
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Label1.Text = "Error was occured!";
            }
        }


    }
}