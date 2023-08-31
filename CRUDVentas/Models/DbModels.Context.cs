﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbModels : DbContext
    {
        public DbModels()
            : base("name=DbModels")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Comision> Tbl_Comision { get; set; }
        public virtual DbSet<Tbl_Region> Tbl_Region { get; set; }
        public virtual DbSet<Tbl_TipoVenta> Tbl_TipoVenta { get; set; }
        public virtual DbSet<Tbl_Vendedor> Tbl_Vendedor { get; set; }
        public virtual DbSet<Tbl_Ventas> Tbl_Ventas { get; set; }
    
        public virtual int ActualizarComision(Nullable<int> id_comision, Nullable<double> margen, string tipo_ventas)
        {
            var id_comisionParameter = id_comision.HasValue ?
                new ObjectParameter("id_comision", id_comision) :
                new ObjectParameter("id_comision", typeof(int));
    
            var margenParameter = margen.HasValue ?
                new ObjectParameter("margen", margen) :
                new ObjectParameter("margen", typeof(double));
    
            var tipo_ventasParameter = tipo_ventas != null ?
                new ObjectParameter("tipo_ventas", tipo_ventas) :
                new ObjectParameter("tipo_ventas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarComision", id_comisionParameter, margenParameter, tipo_ventasParameter);
        }
    
        public virtual int ActualizarRegion(Nullable<int> cod_region, string descripcion)
        {
            var cod_regionParameter = cod_region.HasValue ?
                new ObjectParameter("cod_region", cod_region) :
                new ObjectParameter("cod_region", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarRegion", cod_regionParameter, descripcionParameter);
        }
    
        public virtual int ActualizarTipoVenta(Nullable<int> id_comision, Nullable<double> margen, string tipo_ventas)
        {
            var id_comisionParameter = id_comision.HasValue ?
                new ObjectParameter("id_comision", id_comision) :
                new ObjectParameter("id_comision", typeof(int));
    
            var margenParameter = margen.HasValue ?
                new ObjectParameter("margen", margen) :
                new ObjectParameter("margen", typeof(double));
    
            var tipo_ventasParameter = tipo_ventas != null ?
                new ObjectParameter("tipo_ventas", tipo_ventas) :
                new ObjectParameter("tipo_ventas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarTipoVenta", id_comisionParameter, margenParameter, tipo_ventasParameter);
        }
    
        public virtual int ActualizarVendedor(string rut, string nombre, string a_paterno, string a_materno, string direccion, string fono, string email, Nullable<int> region, string pais)
        {
            var rutParameter = rut != null ?
                new ObjectParameter("rut", rut) :
                new ObjectParameter("rut", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var a_paternoParameter = a_paterno != null ?
                new ObjectParameter("a_paterno", a_paterno) :
                new ObjectParameter("a_paterno", typeof(string));
    
            var a_maternoParameter = a_materno != null ?
                new ObjectParameter("a_materno", a_materno) :
                new ObjectParameter("a_materno", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var fonoParameter = fono != null ?
                new ObjectParameter("fono", fono) :
                new ObjectParameter("fono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var regionParameter = region.HasValue ?
                new ObjectParameter("region", region) :
                new ObjectParameter("region", typeof(int));
    
            var paisParameter = pais != null ?
                new ObjectParameter("pais", pais) :
                new ObjectParameter("pais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarVendedor", rutParameter, nombreParameter, a_paternoParameter, a_maternoParameter, direccionParameter, fonoParameter, emailParameter, regionParameter, paisParameter);
        }
    
        public virtual int ActualizarVenta(Nullable<int> id_venta, string rut_vendedor, Nullable<double> monto, Nullable<double> margen, Nullable<System.DateTime> fecha_venta, Nullable<int> id_usuario)
        {
            var id_ventaParameter = id_venta.HasValue ?
                new ObjectParameter("id_venta", id_venta) :
                new ObjectParameter("id_venta", typeof(int));
    
            var rut_vendedorParameter = rut_vendedor != null ?
                new ObjectParameter("rut_vendedor", rut_vendedor) :
                new ObjectParameter("rut_vendedor", typeof(string));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("monto", monto) :
                new ObjectParameter("monto", typeof(double));
    
            var margenParameter = margen.HasValue ?
                new ObjectParameter("margen", margen) :
                new ObjectParameter("margen", typeof(double));
    
            var fecha_ventaParameter = fecha_venta.HasValue ?
                new ObjectParameter("fecha_venta", fecha_venta) :
                new ObjectParameter("fecha_venta", typeof(System.DateTime));
    
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarVenta", id_ventaParameter, rut_vendedorParameter, montoParameter, margenParameter, fecha_ventaParameter, id_usuarioParameter);
        }
    
        public virtual int AgregarComision(Nullable<double> margen, string tipo_ventas)
        {
            var margenParameter = margen.HasValue ?
                new ObjectParameter("margen", margen) :
                new ObjectParameter("margen", typeof(double));
    
            var tipo_ventasParameter = tipo_ventas != null ?
                new ObjectParameter("tipo_ventas", tipo_ventas) :
                new ObjectParameter("tipo_ventas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarComision", margenParameter, tipo_ventasParameter);
        }
    
        public virtual int AgregarRegion(Nullable<int> cod_region, string descripcion)
        {
            var cod_regionParameter = cod_region.HasValue ?
                new ObjectParameter("cod_region", cod_region) :
                new ObjectParameter("cod_region", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarRegion", cod_regionParameter, descripcionParameter);
        }
    
        public virtual int AgregarTipoVenta(Nullable<int> id_comision, Nullable<double> margen, string tipo_ventas)
        {
            var id_comisionParameter = id_comision.HasValue ?
                new ObjectParameter("id_comision", id_comision) :
                new ObjectParameter("id_comision", typeof(int));
    
            var margenParameter = margen.HasValue ?
                new ObjectParameter("margen", margen) :
                new ObjectParameter("margen", typeof(double));
    
            var tipo_ventasParameter = tipo_ventas != null ?
                new ObjectParameter("tipo_ventas", tipo_ventas) :
                new ObjectParameter("tipo_ventas", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarTipoVenta", id_comisionParameter, margenParameter, tipo_ventasParameter);
        }
    
        public virtual int AgregarVendedor(string rut, string nombre, string a_paterno, string a_materno, string direccion, string fono, string email, Nullable<System.DateTime> fecha_ingreso, Nullable<int> region, string pais)
        {
            var rutParameter = rut != null ?
                new ObjectParameter("rut", rut) :
                new ObjectParameter("rut", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var a_paternoParameter = a_paterno != null ?
                new ObjectParameter("a_paterno", a_paterno) :
                new ObjectParameter("a_paterno", typeof(string));
    
            var a_maternoParameter = a_materno != null ?
                new ObjectParameter("a_materno", a_materno) :
                new ObjectParameter("a_materno", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var fonoParameter = fono != null ?
                new ObjectParameter("fono", fono) :
                new ObjectParameter("fono", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var fecha_ingresoParameter = fecha_ingreso.HasValue ?
                new ObjectParameter("fecha_ingreso", fecha_ingreso) :
                new ObjectParameter("fecha_ingreso", typeof(System.DateTime));
    
            var regionParameter = region.HasValue ?
                new ObjectParameter("region", region) :
                new ObjectParameter("region", typeof(int));
    
            var paisParameter = pais != null ?
                new ObjectParameter("pais", pais) :
                new ObjectParameter("pais", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarVendedor", rutParameter, nombreParameter, a_paternoParameter, a_maternoParameter, direccionParameter, fonoParameter, emailParameter, fecha_ingresoParameter, regionParameter, paisParameter);
        }
    
        public virtual int AgregarVenta(string rut_vendedor, Nullable<double> monto, Nullable<double> margen, Nullable<System.DateTime> fecha_venta, Nullable<int> id_usuario)
        {
            var rut_vendedorParameter = rut_vendedor != null ?
                new ObjectParameter("rut_vendedor", rut_vendedor) :
                new ObjectParameter("rut_vendedor", typeof(string));
    
            var montoParameter = monto.HasValue ?
                new ObjectParameter("monto", monto) :
                new ObjectParameter("monto", typeof(double));
    
            var margenParameter = margen.HasValue ?
                new ObjectParameter("margen", margen) :
                new ObjectParameter("margen", typeof(double));
    
            var fecha_ventaParameter = fecha_venta.HasValue ?
                new ObjectParameter("fecha_venta", fecha_venta) :
                new ObjectParameter("fecha_venta", typeof(System.DateTime));
    
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarVenta", rut_vendedorParameter, montoParameter, margenParameter, fecha_ventaParameter, id_usuarioParameter);
        }
    
        public virtual int EliminarComision(Nullable<int> id_comision)
        {
            var id_comisionParameter = id_comision.HasValue ?
                new ObjectParameter("id_comision", id_comision) :
                new ObjectParameter("id_comision", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarComision", id_comisionParameter);
        }
    
        public virtual int EliminarRegion(Nullable<int> cod_region)
        {
            var cod_regionParameter = cod_region.HasValue ?
                new ObjectParameter("cod_region", cod_region) :
                new ObjectParameter("cod_region", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarRegion", cod_regionParameter);
        }
    
        public virtual int EliminarTipoVenta(Nullable<int> id_comision)
        {
            var id_comisionParameter = id_comision.HasValue ?
                new ObjectParameter("id_comision", id_comision) :
                new ObjectParameter("id_comision", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarTipoVenta", id_comisionParameter);
        }
    
        public virtual int EliminarVendedor(string rut)
        {
            var rutParameter = rut != null ?
                new ObjectParameter("rut", rut) :
                new ObjectParameter("rut", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarVendedor", rutParameter);
        }
    
        public virtual int EliminarVenta(Nullable<int> id_venta)
        {
            var id_ventaParameter = id_venta.HasValue ?
                new ObjectParameter("id_venta", id_venta) :
                new ObjectParameter("id_venta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarVenta", id_ventaParameter);
        }
    
        public virtual ObjectResult<string> GetVendedoresPorRegion(string region)
        {
            var regionParameter = region != null ?
                new ObjectParameter("region", region) :
                new ObjectParameter("region", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetVendedoresPorRegion", regionParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<GetVentasPorFecha_Result> GetVentasPorFecha()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetVentasPorFecha_Result>("GetVentasPorFecha");
        }
    }
}
