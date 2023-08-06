using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalValidation4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string email = TextBox2.Text;
            string classname = RadioButtonList1.SelectedItem.Text;
            string rollno = TextBox3.Text;
            string subjects = string.Empty;

            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected)
                {
                    subjects += item.Text + ", ";
                }
            }
            subjects = subjects.TrimEnd(',', ' ');
            Response.Redirect("Confirmation.aspx?Name=" + name + "&Email=" + email +
               "&rollno=" + rollno + "&classname=" + classname + "&subjects=" + subjects);
        }
    }
}