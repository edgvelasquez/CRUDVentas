//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDVentas.Models
{
    using System;
    
    public partial class GetVentasPorFecha_Result
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> total_comision { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
    }
}