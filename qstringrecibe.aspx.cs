using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea._2
{
    public partial class qstringrecibe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string nombre = Request.QueryString["textNombre"];
            string apellido = Request.QueryString["textApellido"];
            if(nombre != null)
            {
                Response.Write("el nombre es: ");
                Response.Write(nombre);
            }

            if (apellido != null)
            {
                Response.Write("<br>el apellido es: ");
                Response.Write(apellido);
            }


        }

    }
}