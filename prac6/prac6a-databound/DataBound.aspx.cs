using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Practical6a
{
    public partial class DataBound : System.Web.UI.Page
    {
        SqlConnection con = null;
        string cs = "Data Source=LAPTOP-OPRPD79S\\SQLEXPRESS01;Database=MCA;Integrated security=True";
        SqlDataAdapter adapt;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowData();
            }
        }
        //ShowData method for Displaying Data in Gridview 
        protected void ShowData()
        {
            dt = new DataTable();
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("Select ID,NAME,DEGREE,SUBJECT from student", con);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            con.Close();
        }

        protected void GridView1_RowEditing(object sender,
       System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited. 
            GridView1.EditIndex = e.NewEditIndex;
            ShowData();
        }
        protected void GridView1_RowUpdating(object sender,System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update 
            Label id = GridView1.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("txt_NAME") as TextBox;
            TextBox course = GridView1.Rows[e.RowIndex].FindControl("txt_COURSE") as TextBox;
            TextBox subject = GridView1.Rows[e.RowIndex].FindControl("txt_SUBJECT") as TextBox;
            con = new SqlConnection(cs);
            con.Open();
            //updating the record
            SqlCommand cmd = new SqlCommand("Update student set NAME = '"+name.Text+"', DEGREE = '"+course.Text+"', SUBJECT = '"+subject.Text+"' where ID = "+Convert.ToInt32(id.Text),con); 
            cmd.ExecuteNonQuery();
            con.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview 
            GridView1.EditIndex = -1;
            //Call ShowData method for displaying updated data 
            ShowData();
        }
        protected void GridView1_RowCancelingEdit(object sender,System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview 
            GridView1.EditIndex = -1;
            ShowData();
        }
    }
}
