using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _IPC2_F1E1_201800593
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = TextBox1.Text;
            string apellidos = TextBox2.Text;
            string username = TextBox3.Text;
            string contraseña = TextBox4.Text;
            string fechanac = TextBox5.Text;
            string pais = TextBox6.Text;
            string email = TextBox7.Text;
            fechanac = fechanac.Trim('-');

            if (!String.IsNullOrWhiteSpace(nombre) && !String.IsNullOrWhiteSpace(apellidos) && !String.IsNullOrWhiteSpace(username) && !String.IsNullOrWhiteSpace(contraseña) &&
                !String.IsNullOrWhiteSpace(fechanac) && !String.IsNullOrWhiteSpace(pais) && !String.IsNullOrWhiteSpace(email))
            {

                string connectionString = "Data Source= DESKTOP-ISIRGCE; Initial Catalog = Othello; Trusted_Connection = True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand query = new SqlCommand("SELECT username,email from USUARIO where username = '" + username + "' and email = '"+email+"';", connection);

                    using (SqlDataReader reader = query.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            object obj1 = reader["username"].ToString();
                            object obj2 = reader["email"].ToString();

                            if (obj1.Equals(username))
                            {
                                string script = "alert(\"¡Ya hay un usuario con el mismo nombre de usuario registrado!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                connection.Close();
                            }
                            else if (obj2.Equals(email))
                            {
                                string script = "alert(\"¡Ya hay un usuario con el mismo email registrado!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                connection.Close();
                            }
                            else if (obj1.Equals(username) && obj2.Equals(email))
                            {
                                string script = "alert(\"¡Ya hay un usuario con el mismo email y nombre de usuario registrado!\");";
                                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                                connection.Close();
                            }

                        }
                        else
                        {
                            connection.Close();
                            //Aqui pones la consulta
                            string queryString = "INSERT INTO USUARIO VALUES('" + username + "','" + nombre + "','" + apellidos + "','" + contraseña + "','" + fechanac + "','" + pais + "','" + email + "')";


                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Connection.Open();
                            //Aqui se abre la conexión

                            command.ExecuteNonQuery();

                            //Aqui Se cierra la conexión
                            command.Connection.Close();
                        }
                    } 
                }
            }
            else
            {
                string script = "alert(\"¡Debe llenar todos los campos!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
        }
    }
}