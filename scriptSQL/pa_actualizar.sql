CREATE PROCEDURE ActualizarVendedor
@rut varchar(50),
@nombre varchar(50),
@a_paterno varchar(50),
@a_materno varchar(50),
@direccion varchar(200),
@fono varchar(50),
@email varchar(100),
@region int,
@pais varchar(50)
AS 

BEGIN
	
	update Tbl_Vendedor set nombre=@nombre,a_paterno=@a_paterno,a_materno=@a_materno,direccion=@direccion,fono=@fono,email=@email,region=@region,pais=@pais where rut=@rut;
	
END
GO

CREATE PROCEDURE ActualizarRegion
@cod_region int,
@descripcion varchar(50)
AS
BEGIN
	update Tbl_Region set descripcion=@descripcion where cod_region=@cod_region;
END
GO

CREATE PROCEDURE ActualizarVenta
@id_venta int,
@rut_vendedor varchar(50),
@monto float,
@margen float,
@fecha_venta date,
@id_usuario int
AS
BEGIN
	update Tbl_Ventas set rut_vendedor=@rut_vendedor,monto=@monto,margen=@margen,fecha_venta=@fecha_venta,id_usuario=@id_usuario where id_venta=@id_venta;
END
GO

CREATE PROCEDURE ActualizarComision
@id_comision int,
@margen float,
@tipo_ventas varchar(50)
AS
BEGIN
	update Tbl_Comision set margen=@margen,tipo_ventas=@tipo_ventas where id_comision=@id_comision;
END
GO

CREATE PROCEDURE ActualizarTipoVenta
@id_comision int,
@margen float,
@tipo_ventas varchar(50)
AS
BEGIN
	update Tbl_TipoVenta set id_comision=@id_comision,margen=@margen,tipo_ventas=@tipo_ventas where id_comision=@id_comision;
END
GO
