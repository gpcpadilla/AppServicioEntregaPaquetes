using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AppServicioEntregaPaquete.Web
{
    public partial class Enviar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EnviosRepositorios lista = new EnviosRepositorios();

            string result = "";

            foreach (Package element in lista.getPackage())
                result += "/n" + element;

            Label1.Text = result.ToString().Replace("/n", "</br>");
        }
    }
}