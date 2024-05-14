using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaPracticaPromerica
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string username = txtUsuario.Text;
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Label label = new Label();
                Label1.Visible = true;
                Label1.ForeColor = System.Drawing.Color.Red;
                Label2.Visible = true;
                Label2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                // Ejemplo de redirección tras una validación exitosa
               Response.Redirect("PaginaPrincipal.aspx");
            }
        }
    }
}