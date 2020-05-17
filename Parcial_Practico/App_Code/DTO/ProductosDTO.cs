using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial_Practico
{
    public class ProductosDTO
    {
        public int Codigos { get; set; }
        public string Nombre_Producto { get; set; }
        public int id_Categoria { get; set; }
        public decimal Precio_unitario { get; set; }
        public string Detalles { get; set; }

    }
}