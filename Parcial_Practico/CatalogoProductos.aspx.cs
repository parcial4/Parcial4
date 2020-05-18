using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Parcial_Practico;

namespace Parcial_Practico
{
    public partial class CatalogoProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            CarroDeCompras carrito = CarroDeCompras.CapturarProducto();

            Button Button2 = (Button)sender;

            int ID = int.Parse(Button2.CommandArgument);

            carrito.Agregar(ID);
            Response.Redirect("VerCarrito.aspx");
        }
    }
}