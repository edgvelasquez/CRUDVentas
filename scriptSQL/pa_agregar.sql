CREATE PROCEDURE AgregarVendedor
@rut varchar(50),
@nombre varchar(50),
@a_paterno varchar(50),
@a_materno varchar(50),
@direccion varchar(200),
@fono varchar(50),
@email varchar(100),
@fecha_ingreso date,
@region int,
@pais varchar(50)
AS 

BEGIN
	IF (select rut from Tbl_Vendedor where rut=@rut) is null
		insert into Tbl_Vendedor values(@rut,@nombre,@a_materno,@a_materno,@direccion,@fono,@email,@fecha_ingreso,@region,@pais);
	
END
GO

CREATE PROCEDURE AgregarRegion
@cod_region int,
@descripcion varchar(50)
AS
BEGIN
	IF (select cod_region from Tbl_Region where cod_region=@cod_region) is null
		insert into Tbl_Region values(@cod_region,@descripcion);
END
GO

CREATE PROCEDURE AgregarVenta
@rut_vendedor varchar(50),
@monto float,
@margen float,
@fecha_venta date,
@id_usuario int
AS
BEGIN
	insert into Tbl_Ventas(rut_vendedor,monto,margen,fecha_venta,id_usuario) values(@rut_vendedor,@monto,@margen,@fecha_venta,@id_usuario);
END
GO

CREATE PROCEDURE AgregarComision
@margen float,
@tipo_ventas varchar(50)
AS
BEGIN
	insert into Tbl_Comision(margen,tipo_ventas) values(@margen,@tipo_ventas);
END
GO

CREATE PROCEDURE AgregarTipoVenta
@id_comision int,
@margen float,
@tipo_ventas varchar(50)
AS
BEGIN
	insert into Tbl_TipoVenta values(@id_comision,@margen,@tipo_ventas);
END
GO
