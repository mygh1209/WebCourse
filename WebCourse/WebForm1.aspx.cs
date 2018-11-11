using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCourse
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "hi";
            Response.Write(a);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("ok");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("aaa");
        }
    }
}