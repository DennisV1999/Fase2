using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _IPC2_F1E1_201800593
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Name = Request.QueryString["username"];
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estadisticas.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Tablero.aspx");
        }
    }
}