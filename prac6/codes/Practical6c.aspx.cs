using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_6
{
    public partial class Practical6c : System.Web.UI.Page
    {

        DataSet ds = new DataSet();
        SqlConnection con;
        //Here we declare the parameter which we have to use in our application
        SqlCommand cmd = new SqlCommand();
        SqlParameter sp1 = new SqlParameter();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ConString = "Data Source=LAPTOP-LABV26J8;Initial Catalog=MCA;Integrated Security=True";
            con = new SqlConnection(ConString);
            cmd = new SqlCommand("SunnyParamProcedure", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EMPID", SqlDbType.Int).Value = int.Parse(TextBox1.Text);
            cmd.Parameters.Add("@EMPNAME", SqlDbType.NVarChar).Value = TextBox2.Text;
            cmd.Parameters.Add("@DEPT", SqlDbType.NVarChar).Value = TextBox3.Text;
            con.Open(); 
            try
            {
                cmd.ExecuteNonQuery();
                Label1.Text = "Data Inserted";
                GridView1.DataBind();
            }
            catch(Exception ex) {
                Label1.Text = "Data Not Inserted";
            }

            
            

        }
    }
}