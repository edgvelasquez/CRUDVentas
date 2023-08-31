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
    public class ExportComision
    {
        public MemoryStream GenerateExcelComisiones(List<Tbl_Comision> comisiones)
        {
            DataTable dt = new DataTable("Comisiones");
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("id_comision"),
                new DataColumn("margen"),
                new DataColumn("tipo_ventas")
            });

            foreach (var comision in comisiones)
            {
                dt.Rows.Add(comision.id_comision, comision.margen, comision.tipo_ventas);
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