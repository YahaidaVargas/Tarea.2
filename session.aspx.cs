using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea._2
{
    public partial class session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e) {
            ArrayList productos;
            if (Session["s_producto"] != null)
                productos = (ArrayList)Session["s_producto"];
            else
                productos = new ArrayList();
            productos.Add(this.txtProducto.Text.ToString());
            this.txtProducto.Text = string.Empty;
            Session["s_producto"] = productos;
        }
    }
}