using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Inventario.WebAdmin.Models
{
    public class InventarioDetalle
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }

        public string Ubicacion { get; set; }

        public int Existencia { get; set; }

        public int InventarioId { get; set; }

        virtual public Inventario Inventario { get; set; }
    }
}