using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Ajax.Utilities;

namespace _IPC2_F1E1_201800593
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source= DESKTOP-ISIRGCE; Initial Catalog = Othello; Trusted_Connection = True";
            string username = TextBox1.Text;
            string contraseña = TextBox2.Text;

            if (!String.IsNullOrWhiteSpace(username) && !String.IsNullOrWhiteSpace(contraseña))
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand query = new SqlCommand("SELECT username,contraseña from USUARIO where username = '" + username + "' and " + "contraseña = '" + contraseña + "';", connection);

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        object obj1 = reader["username"].ToString();
                        object obj2 = reader["contraseña"].ToString();

                        if (obj1.Equals(username) && obj2.Equals(contraseña))
                        {
                            connection.Close();
                            Response.Redirect("Opciones.aspx?username=" + username);
                        }
                        connection.Close();

                    }
                    else
                    {
                        string script = "alert(\"¡El nombre de usuario o la contraseña son inválidos!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        connection.Close();
                    }
                }
            }
            else
            {
                string script = "alert(\"¡Debe ingresar un nombre de usuario y una contraseña!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            
        }
    }
}