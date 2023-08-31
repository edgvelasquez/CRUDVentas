using CRUDVentas.ExportExcel;
using CRUDVentas.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CRUDVentas.Controllers
{
    public class ComisionController : Controller
    {
        // GET: Comision
        public ActionResult Index()
        {
           
            using(DbModels context=new DbModels())
            {
                return View(context.Tbl_Comision.ToList());
            }
           
        }

        // GET: Comision/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comision/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comision/Create
        [HttpPost]
        public ActionResult Create(Tbl_Comision comision)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.AgregarComision(comision.margen,comision.tipo_ventas);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comision/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Tbl_Comision.Where(x => x.id_comision == id).FirstOrDefault());
            }
        }

        // POST: Comision/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tbl_Comision comision)
        {
            try
            {
                // TODO: Add update logic here
                using(DbModels context=new DbModels())
                {
                    context.ActualizarComision(comision.id_comision,comision.margen,comision.tipo_ventas);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comision/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Tbl_Comision.Where(x => x.id_comision == id).FirstOrDefault());
            }
        }

        // POST: Comision/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using(DbModels context= new DbModels())
                {
                    context.EliminarComision(id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public FileResult Export()
        {

            using (DbModels context = new DbModels())
            {
                ExportComision ev = new ExportComision();
                MemoryStream ms = ev.GenerateExcelComisiones(context.Tbl_Comision.ToList());

                return File(ms.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "comisiones.xlsx");

            }
        }
    }
}
