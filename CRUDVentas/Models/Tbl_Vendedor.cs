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
    using System.Collections.Generic;
    
    public partial class Tbl_Vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Vendedor()
        {
            this.Tbl_Ventas = new HashSet<Tbl_Ventas>();
        }
    
        public string rut { get; set; }
        public string nombre { get; set; }
        public string a_paterno { get; set; }
        public string a_materno { get; set; }
        public string direccion { get; set; }
        public string fono { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> fecha_ingreso { get; set; }
        public int region { get; set; }
        public string pais { get; set; }
    
        public virtual Tbl_Region Tbl_Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ventas> Tbl_Ventas { get; set; }
    }
}