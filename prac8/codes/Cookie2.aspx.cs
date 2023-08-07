﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Practical_8
{
    public partial class Cookie2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie reqCookies = Request.Cookies["userInfo"];
            if (reqCookies != null)
            {
                Label1.Text = reqCookies["name"].ToString();
                Label2.Text = reqCookies["age"].ToString();
                Label3.Text = reqCookies["branch"].ToString();
            }
        }
    }
}