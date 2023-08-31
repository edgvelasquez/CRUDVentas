CREATE PROCEDURE EliminarVendedor
@rut varchar(50)
AS

BEGIN
	delete from Tbl_Vendedor where rut=@rut;
END
GO

CREATE PROCEDURE EliminarRegion
@cod_region int
AS
BEGIN
	delete from Tbl_Region where cod_region= @cod_region;
END
GO

CREATE PROCEDURE EliminarVenta
@id_venta int
AS
BEGIN
	delete from Tbl_Ventas where id_venta=@id_venta;
END
GO

CREATE PROCEDURE EliminarComision
@id_comision int
AS
BEGIN
	delete from Tbl_Comision where id_comision=@id_comision;
END
GO

CREATE PROCEDURE EliminarTipoVenta
@id_comision int
AS
BEGIN
	delete from Tbl_TipoVenta where id_comision=@id_comision;
END
GO 
