using CRUDVentas.ExportExcel;
using CRUDVentas.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CRUDVentas.Controllers
{
    public class VentaController : Controller
    {
        // GET: Venta
        public ActionResult Index()
        {
            using(DbModels context=new DbModels())
            {
                return View(context.Tbl_Ventas.Include("Tbl_Vendedor").Include("Tbl_Comision").ToList());
            }
            
        }

        // GET: Venta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Venta/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {
                IEnumerable<String> objecto = context.GetVendedoresPorRegion("Metropolitana");
                ViewBag.vendedores = objecto.FirstOrDefault().ToString();
                ViewBag.comisiones= new SelectList(context.Tbl_Comision.ToList(), "id_comision", "margen");
                return View();
            }
                
        }

        // POST: Venta/Create
        [HttpPost]
        public ActionResult Create(Tbl_Ventas venta,FormCollection form)
        {
            try
            {
               
                venta.fecha_venta = DateTime.Now;
                venta.margen = Int32.Parse(form["comisiones"]);
                venta.rut_vendedor = form["vendedores"];
                using (DbModels context = new DbModels())
                {
                    context.AgregarVenta(venta.rut_vendedor,venta.monto,venta.margen,venta.fecha_venta,venta.id_usuario);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Venta/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                IEnumerable<String> objecto = context.GetVendedoresPorRegion("Metropolitana");
                ViewBag.vendedores = objecto.FirstOrDefault().ToString();
                ViewBag.comisiones = new SelectList(context.Tbl_Comision.ToList(), "id_comision", "margen");
                return View(context.Tbl_Ventas.Where(r => r.id_venta == id).FirstOrDefault());
            }
        }

        // POST: Venta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Tbl_Ventas venta,FormCollection form)
        {
            try
            {
                // TODO: Add update logic here
                venta.margen = Int32.Parse(form["comisiones"]);
                venta.rut_vendedor = form["vendedores"];
                using (DbModels context = new DbModels())
                {
                    context.ActualizarVenta(venta.id_venta, venta.rut_vendedor, venta.monto, venta.margen, venta.fecha_venta, venta.id_usuario);
                }
                return RedirectToAction("Index");
            }
            catch 
            {
                return View();
            }
        }

        // GET: Venta/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Tbl_Ventas.Where(r => r.id_venta == id).FirstOrDefault());
            }
        }

        // POST: Venta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels context = new DbModels())
                {
                    context.EliminarVenta(id);
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
                ExportVentas ev = new ExportVentas();
                MemoryStream ms = ev.GenerateExcelVentas(context.Tbl_Ventas.Include("Tbl_Comision").ToList());

                return File(ms.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "ventas.xlsx");

            }
        }
        [HttpGet]
        public FileResult ExportVentas()
        {

            using (DbModels context = new DbModels())
            {
                ExportVentas ev = new ExportVentas();
                
                MemoryStream ms = ev.GenerateExcelVentasPorFecha(context.GetVentasPorFecha().ToList());

                return File(ms.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "ventas_marzo_junio_2022.xlsx");

            }
        }
    }
}
