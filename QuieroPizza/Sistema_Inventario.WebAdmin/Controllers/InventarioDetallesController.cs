using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sistema_Inventario.WebAdmin.Models;

namespace Sistema_Inventario.WebAdmin.Controllers
{
    public class InventarioDetallesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

     
        public ActionResult Create()
        {
            ViewBag.InventarioId = new SelectList(db.Inventarios.Include(a =>a.Bodega) , "Id", "Bodega.Nombre");
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductoId,Ubicacion,Existencia,InventarioId")] InventarioDetalle inventarioDetalle)
        {
            if (ModelState.IsValid)
            {
                db.InventarioDetalles.Add(inventarioDetalle);
                db.SaveChanges();
                return RedirectToAction("Index", "Inventarios");
            }

            ViewBag.InventarioId = new SelectList(db.Inventarios.Include(a => a.Bodega), "Id", "Bodega.Nombre", inventarioDetalle.InventarioId);
            return View(inventarioDetalle);
        }

 
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
