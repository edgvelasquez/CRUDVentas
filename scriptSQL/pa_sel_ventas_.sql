CREATE PROCEDURE GetVentasPorFecha
AS
BEGIN
	select vendedor.rut,vendedor.nombre,SUM(venta.monto) as total, SUM(venta.monto*comision.margen/100) as total_comision,venta.fecha_venta 
	from Tbl_Vendedor vendedor,Tbl_Ventas venta,Tbl_Comision comision,Tbl_Region region 
	where vendedor.rut=venta.rut_vendedor and comision.id_comision=venta.margen and region.cod_region=vendedor.region and 
	((MONTH(fecha_venta)=3 and YEAR(fecha_venta)=2022) or (MONTH(fecha_venta)=6 and YEAR(fecha_venta)=2022)) and 
	(region.descripcion='Metropolitana' or region.descripcion='Rancagua') group by vendedor.rut,vendedor.nombre,venta.fecha_venta order by vendedor.nombre,vendedor.rut,venta.fecha_venta asc;
END
GO 