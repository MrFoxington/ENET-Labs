using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_3
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_EnterName_Click(object sender, EventArgs e)
        {
            lbl_Name.Text = "Why hello there, " + txtBox_EnterName.Text;
            lbl_Name.Visible = true;
        }

    }
}