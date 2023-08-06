using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticalValidation4
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["Name"] != null && Request.QueryString["Email"] !=null && Request.QueryString["rollno"] != null
                    && Request.QueryString["classname"] != null && Request.QueryString["subjects"] != null)
                {
                    string name = Request.QueryString["Name"];
                    string email = Request.QueryString["Email"];
                    string rollno = Request.QueryString["rollno"];
                    string classname = Request.QueryString["classname"];
                    string subjects = Request.QueryString["subjects"];

                    Label1.Text = "<h3>You have successfully registered! Here is the information you entered:</ h3 > " +
                    "<br />Name: " + name +
                    "<br />Email: " + email +
                    "<br />Roll No: " + rollno +
                    "<br />Class: " + classname +
                    "<br />subjects: " + subjects;

                }
            }

        }
    }
}