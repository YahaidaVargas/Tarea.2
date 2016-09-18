using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea._2
{
    public partial class cookieinicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["preferencias"];

            if (cookie == null)
                this.lblMensaje.Text = "no hay preferencias definidas";
            else
                this.lblMensaje.Text = cookie["Nombre"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["preferencias"];
            if (cookie == null)
                cookie = new HttpCookie("Preferencias");
            cookie["Nombre"] = this.txtNombre.Text;
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            this.lblMensaje.Text = this.txtNombre.Text;


        }
    }
}