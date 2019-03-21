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

        // GET: InventarioDetalles
        public ActionResult Index()
        {
            var inventarioDetalles = db.InventarioDetalles.Include(i => i.Inventario);
            return View(inventarioDetalles.ToList());
        }

        // GET: InventarioDetalles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventarioDetalle inventarioDetalle = db.InventarioDetalles.Find(id);
            if (inventarioDetalle == null)
            {
                return HttpNotFound();
            }
            return View(inventarioDetalle);
        }

        // GET: InventarioDetalles/Create
        public ActionResult Create()
        {
            ViewBag.InventarioId = new SelectList(db.Inventarios, "Id", "Id");
            return View();
        }

        // POST: InventarioDetalles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductoId,Ubicacion,Existencia,InventarioId")] InventarioDetalle inventarioDetalle)
        {
            if (ModelState.IsValid)
            {
                db.InventarioDetalles.Add(inventarioDetalle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.InventarioId = new SelectList(db.Inventarios, "Id", "Id", inventarioDetalle.InventarioId);
            return View(inventarioDetalle);
        }

        // GET: InventarioDetalles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventarioDetalle inventarioDetalle = db.InventarioDetalles.Find(id);
            if (inventarioDetalle == null)
            {
                return HttpNotFound();
            }
            ViewBag.InventarioId = new SelectList(db.Inventarios, "Id", "Id", inventarioDetalle.InventarioId);
            return View(inventarioDetalle);
        }

        // POST: InventarioDetalles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProductoId,Ubicacion,Existencia,InventarioId")] InventarioDetalle inventarioDetalle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventarioDetalle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.InventarioId = new SelectList(db.Inventarios, "Id", "Id", inventarioDetalle.InventarioId);
            return View(inventarioDetalle);
        }

        // GET: InventarioDetalles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventarioDetalle inventarioDetalle = db.InventarioDetalles.Find(id);
            if (inventarioDetalle == null)
            {
                return HttpNotFound();
            }
            return View(inventarioDetalle);
        }

        // POST: InventarioDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InventarioDetalle inventarioDetalle = db.InventarioDetalles.Find(id);
            db.InventarioDetalles.Remove(inventarioDetalle);
            db.SaveChanges();
            return RedirectToAction("Index");
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
