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
    
    public partial class Tbl_Comision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Comision()
        {
            this.Tbl_TipoVenta = new HashSet<Tbl_TipoVenta>();
            this.Tbl_Ventas = new HashSet<Tbl_Ventas>();
        }
    
        public int id_comision { get; set; }
        public Nullable<double> margen { get; set; }
        public string tipo_ventas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_TipoVenta> Tbl_TipoVenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Ventas> Tbl_Ventas { get; set; }
    }
}
