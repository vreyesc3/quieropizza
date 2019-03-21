using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Inventario.WebAdmin.Models
{
    public class Inventario
    {

        public int Id { get; set; }

        public int BodegaId { get; set; }

        virtual public Bodega Bodega { get; set; }

        public ICollection<InventarioDetalle> InventarioDetalle { get; set; }
    }
}