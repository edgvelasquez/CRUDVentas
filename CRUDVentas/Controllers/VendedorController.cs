using CRUDVentas.ExportExcel;
using CRUDVentas.Models;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CRUDVentas.Controllers
{
    public class VendedorController : Controller
    {
        // GET: Vendedor
        public ActionResult Index()
        {

            using (DbModels context = new DbModels())
            {

                return View(context.Tbl_Vendedor.Include("Tbl_Region").ToList());
            }

        }

        // GET: Vendedor/Details/5
        public ActionResult Details(int rut)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Tbl_Vendedor.Where(x => x.rut.Equals(rut)));
            }
        }

        // GET: Vendedor/Create
        public ActionResult Create()
        {
            using (DbModels context = new DbModels())
            {

                ViewBag.regiones = new SelectList(context.Tbl_Region.ToList(), "cod_region", "descripcion");
                return View();
            }

        }

        // POST: Vendedor/Create
        [HttpPost]
        public ActionResult Create(Tbl_Vendedor vendedor, FormCollection form)
        {
            try
            {
                // TODO: Add insert logic here

                vendedor.fecha_ingreso = DateTime.Now;
                vendedor.region = Int32.Parse(form["regiones"]);

                using (DbModels context = new DbModels())
                {
                    context.AgregarVendedor(vendedor.rut, vendedor.nombre, vendedor.a_paterno, vendedor.a_materno, vendedor.direccion, vendedor.fono, vendedor.email, vendedor.fecha_ingreso, vendedor.region, vendedor.pais);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vendedor/Edit/5
        public ActionResult Edit(string id)
        {
            using (DbModels context = new DbModels())
            {
                Tbl_Vendedor vendedor = context.Tbl_Vendedor.Where(x => x.rut.Equals(id)).FirstOrDefault();
                ViewBag.regiones = new SelectList(context.Tbl_Region.ToList(), "cod_region", "descripcion");
                return View(vendedor);
            }
        }

        // POST: Vendedor/Edit/5
        [HttpPost]
        public ActionResult Edit(Tbl_Vendedor vendedor, FormCollection form)
        {
            try
            {
                vendedor.region = Int32.Parse(form["regiones"]);

                using (DbModels context = new DbModels())
                {
                    ViewBag.regiones = new SelectList(context.Tbl_Region.ToList(), "cod_region", "descripcion");
                    context.ActualizarVendedor(vendedor.rut, vendedor.nombre, vendedor.a_paterno, vendedor.a_materno, vendedor.direccion, vendedor.fono, vendedor.email, vendedor.region, vendedor.pais);
                }

                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        // GET: Vendedor/Delete/5
        public ActionResult Delete(string id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Tbl_Vendedor.Where(x => x.rut.Equals(id)).FirstOrDefault());
            }
        }

        // POST: Vendedor/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.EliminarVendedor(id);
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
                ExportVendedor ev = new ExportVendedor();
                MemoryStream ms = ev.GenerateExcelVendedores(context.Tbl_Vendedor.Include("Tbl_Region").ToList());

                return File(ms.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "vendedores.xlsx");

            }
        }
    }
}
