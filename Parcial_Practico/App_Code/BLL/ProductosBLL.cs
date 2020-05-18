using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parcial_Practico;

namespace Parcial_Practico
{
    public class ProductosBLL
    {
        List<ProductosDTO> ListarProductos = new List<ProductosDTO>();

        public List<ProductosDTO> MostrarTodosProductos()
        {
            ProductosDALTableAdapters.MostrarProductosTableAdapter adaptador = new ProductosDALTableAdapters.MostrarProductosTableAdapter();
            ProductosDAL.MostrarProductosDataTable tabla = adaptador.MostrarProductos();

            foreach (ProductosDAL.MostrarProductosRow filas in tabla)
            {
                ListarProductos.Add(filaDTOProducto(filas));
            }

            return ListarProductos;
        }

        private ProductosDTO filaDTOProducto(ProductosDAL.MostrarProductosRow filas)
        {
            ProductosDTO objProducto = new ProductosDTO();
            objProducto.ID = filas.ID;
            objProducto.Codigo = filas.CÓDIGO;
            objProducto.Nombre_Producto = filas.NOMBRE;
            objProducto.id_Categoria = filas.CATEGORÍA;
            objProducto.Precio_unitario = filas.PRECIO;
            objProducto.Detalles = filas.DETALLES_DEL_PRODUCTO;

            ProductosAlCarro objPro1 = new ProductosAlCarro(filas.ID);
            objPro1.IdProducto = filas.ID;

            return objProducto;
        }
    }
}