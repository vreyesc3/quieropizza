using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Inventario.WebAdmin.Models
{
    public class InventarioDetalleViewmodel:Inventario
    {
        public IEnumerable<InventarioDetalle> invedete { get; set; }
    }
}