using ClosedXML.Excel;
using CRUDVentas.Models;
using System.Collections.Generic;
using System.Data;
using System.IO;


namespace CRUDVentas.ExportExcel
{
    public class ExportVendedor
    {
        public MemoryStream GenerateExcelVendedores(List<Tbl_Vendedor> vendedores)
        {
            DataTable dt = new DataTable("Vendedores");
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("rut"),
                new DataColumn("nombre"),
                new DataColumn("a_paterno"),
                new DataColumn("a_materno"),
                new DataColumn("direccion"),
                new DataColumn("fono"),
                new DataColumn("email"),
                new DataColumn("fecha_ingreso"),
                new DataColumn("region"),
                new DataColumn("pais"),
            });

            foreach(var vendedor in vendedores)
            {
                dt.Rows.Add(vendedor.rut, vendedor.nombre, vendedor.a_paterno, vendedor.a_materno, vendedor.direccion, vendedor.fono, vendedor.email, vendedor.fecha_ingreso, vendedor.Tbl_Region.descripcion, vendedor.pais);
            }
            using(XLWorkbook wb= new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using(MemoryStream ms= new MemoryStream())
                {
                    wb.SaveAs(ms);
                    return ms;
                }
            }
        }
    }
}