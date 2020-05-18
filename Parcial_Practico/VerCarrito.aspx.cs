using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Parcial_Practico
{
    public partial class VerCarrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindData();
        }

        protected void BindData()
        {
            GridView2.DataSource = CarroDeCompras.CapturarProducto().ListaProductos;
            GridView2.DataBind();
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[3].Text = "Total: " +CarroDeCompras.CapturarProducto().SubTotal().ToString("C");
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Eliminar")
            {
                int productId = Convert.ToInt32(e.CommandArgument);
                CarroDeCompras.CapturarProducto().EliminarProductos(productId);
            }
            BindData();
        }
    }
}