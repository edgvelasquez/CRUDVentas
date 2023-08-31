using ClosedXML.Excel;
using CRUDVentas.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDVentas.ExportExcel
{
    public class ExportVentas
    {
        public MemoryStream GenerateExcelVentas(List<Tbl_Ventas> ventas)
        {
            DataTable dt = new DataTable("Ventas");
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("id_venta"),
                new DataColumn("rut_vendedor"), 
                new DataColumn("monto"),
                new DataColumn("margen"),
                new DataColumn("fecha_venta"),
                new DataColumn("id_usuario")
            });
            foreach (var venta in ventas)
            {
                dt.Rows.Add(venta.id_venta,venta.rut_vendedor,venta.monto,venta.Tbl_Comision.margen,venta.fecha_venta,venta.id_usuario);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream ms = new MemoryStream())
                {
                    wb.SaveAs(ms);
                    return ms;
                }
            }

        }
        public MemoryStream GenerateExcelVentasPorFecha(List<GetVentasPorFecha_Result> ventas)
        {
            DataTable dt = new DataTable("Ventas");
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("rut"),
                new DataColumn("nombre"),
                new DataColumn("total"),
                new DataColumn("total_comision"),
                new DataColumn("fecha_venta")
            });
            foreach (var venta in ventas)
            {
                dt.Rows.Add(venta.rut,venta.nombre,venta.total,venta.total_comision,venta.fecha_venta);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream ms = new MemoryStream())
                {
                    wb.SaveAs(ms);
                    return ms;
                }
            }

        }
    }
}