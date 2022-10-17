using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_Msg.Text = "Page_Load";
        }

        protected System.Void btn_Submit_Click(System.Object sender, System.EventArgs e)
        {
            lb_Msg.Text = "btn_Event";
        }
    }
}