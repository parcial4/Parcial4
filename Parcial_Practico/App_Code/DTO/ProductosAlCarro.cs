using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_Practico
{
    public class ProductosAlCarro : IEquatable<ProductosAlCarro>
    {
        private int _idProducto;
        private ProductosDTO _producto = null;
        public int Cantidad { get; set; }

        public int IdProducto
        {
            get { return _idProducto; }
            set
            {
                _producto = null;
                _idProducto = value;
            }
        }

        public ProductosDTO Producto
        {
            get
            {
                if (_producto == null)
                {
                    _producto = new ProductosDTO();
                    
                }
                return _producto;
            }
        }

        public string Descripcion
        {
            get { return Producto.Detalles; }
        }
        public decimal PrecioUnitario
        {
            get { return Producto.Precio_unitario; }
        }
        public decimal Total
        {
            get { return PrecioUnitario * Cantidad; }
        }

        public ProductosAlCarro(int pId)
        {
            IdProducto = pId;
        }

        public bool Equals(ProductosAlCarro pItem)
        {
            return pItem.IdProducto == IdProducto;
        }
    }
}