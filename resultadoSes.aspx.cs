using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Tarea._2
{
    public partial class resultadoSes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList productos = new ArrayList();
            if (Session["s_producto"] != null)
            {
                productos = (ArrayList)Session["s_producto"];
                foreach (string item in productos)
                    Response.Write(item + "<br/>");
            
            }
            else
            {

                Response.Write("no cargo ningun producto");
            }
        }
        
    }
}