USE DB_PROD_VENTAS;

GO
CREATE PROCEDURE GetVendedoresPorRegion
@region varchar(30)
AS

BEGIN
	
	select 'vendedores' as '@id','vendedores' as '@name','form-control' as '@class',
	(
	select rut as '@value',nombre+'' from Tbl_Vendedor,Tbl_Region where region=cod_region and descripcion=@region FOR XML PATH('option'),TYPE
	)
	FOR XML PATH ('select'),ELEMENTS
	
END 