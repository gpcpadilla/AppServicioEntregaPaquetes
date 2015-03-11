using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppServicioEntregaPaquete.Modelo;
using AppServicioEntregaPaquete.Datos;

namespace AppServicioEntregaPaquete.Web
{
    public partial class envio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Repositorios lista = new Repositorios();

            string result = "";

            foreach (Package element in lista.getPackage())
                result += "/n" + element;

            Label1.Text = result.ToString().Replace("/n", "</br>");
        }
    }
}