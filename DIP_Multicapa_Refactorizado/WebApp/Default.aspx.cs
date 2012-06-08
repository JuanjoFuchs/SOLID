using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoDatos.SQL;

namespace WebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int idUsuario = new Negocio.Seguridad(new RepositorioUsuariosSQL()).Login(txtEmail.Text, txtPassword.Text);
        }
    }
}
