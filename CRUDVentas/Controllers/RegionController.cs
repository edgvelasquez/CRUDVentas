using CRUDVentas.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDVentas.Controllers
{
    public class RegionController : Controller
    {
        // GET: Region
        public ActionResult Index()
        {
            using(DbModels context = new DbModels())
            {
                return View(context.Tbl_Region.ToList());
            }
            
        }

        // GET: Region/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Region/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Region/Create
        [HttpPost]
        public ActionResult Create(Tbl_Region region)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels context = new DbModels())
                {
                    context.AgregarRegion(region.cod_region, region.descripcion);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Region/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Tbl_Region.Where(r=>r.cod_region==id).FirstOrDefault());
            }
           
        }

        // POST: Region/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tbl_Region region)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels context = new DbModels())
                {
                    context.ActualizarRegion(region.cod_region, region.descripcion);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Region/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Tbl_Region.Where(r => r.cod_region == id).FirstOrDefault());
            }
            
        }

        // POST: Region/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.EliminarRegion(id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
