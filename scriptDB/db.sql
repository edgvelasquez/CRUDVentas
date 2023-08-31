USE [DB_PROD_VENTAS]
GO
/****** Object:  Table [dbo].[Tbl_Comision]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Comision](
	[id_comision] [int] IDENTITY(1,1) NOT NULL,
	[margen] [float] NULL,
	[tipo_ventas] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Comision] PRIMARY KEY CLUSTERED 
(
	[id_comision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Region]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Region](
	[cod_region] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Region] PRIMARY KEY CLUSTERED 
(
	[cod_region] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_TipoVenta]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_TipoVenta](
	[id_comision] [int] NOT NULL,
	[margen] [float] NULL,
	[tipo_ventas] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_TipoVenta] PRIMARY KEY CLUSTERED 
(
	[tipo_ventas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Vendedor]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Vendedor](
	[rut] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[a_paterno] [varchar](50) NULL,
	[a_materno] [varchar](50) NULL,
	[direccion] [varchar](200) NULL,
	[fono] [varchar](50) NULL,
	[email] [varchar](100) NULL,
	[fecha_ingreso] [date] NULL,
	[region] [int] NOT NULL,
	[pais] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Vendedor] PRIMARY KEY CLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Ventas]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Ventas](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[rut_vendedor] [varchar](50) NOT NULL,
	[monto] [float] NULL,
	[margen] [int] NOT NULL,
	[fecha_venta] [date] NULL,
	[id_usuario] [int] NULL,
 CONSTRAINT [PK_Tbl_Ventas] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Comision] ON 
GO
INSERT [dbo].[Tbl_Comision] ([id_comision], [margen], [tipo_ventas]) VALUES (2, 15, N'B')
GO
INSERT [dbo].[Tbl_Comision] ([id_comision], [margen], [tipo_ventas]) VALUES (3, 30, N'C')
GO
INSERT [dbo].[Tbl_Comision] ([id_comision], [margen], [tipo_ventas]) VALUES (5, 60, N'AG')
GO
SET IDENTITY_INSERT [dbo].[Tbl_Comision] OFF
GO
INSERT [dbo].[Tbl_Region] ([cod_region], [descripcion]) VALUES (2, N'Antofagasta')
GO
INSERT [dbo].[Tbl_Region] ([cod_region], [descripcion]) VALUES (3, N'Metropolitana')
GO
INSERT [dbo].[Tbl_Region] ([cod_region], [descripcion]) VALUES (4, N'Rancagua')
GO
INSERT [dbo].[Tbl_Vendedor] ([rut], [nombre], [a_paterno], [a_materno], [direccion], [fono], [email], [fecha_ingreso], [region], [pais]) VALUES (N'15972318-2', N'Jose', N'Herrera', N'Fuentes', N'Talca 1856', N'+56939547788', N'jherrera@gmail.com', CAST(N'2023-08-29' AS Date), 2, N'Chile')
GO
INSERT [dbo].[Tbl_Vendedor] ([rut], [nombre], [a_paterno], [a_materno], [direccion], [fono], [email], [fecha_ingreso], [region], [pais]) VALUES (N'15972318-3', N'Carlos', N'Vera', N'Guaitiao', N'Comité número uno', N'+56959896457', N'carlos.vera@gmail.com', CAST(N'2023-08-30' AS Date), 3, N'Argentina')
GO
INSERT [dbo].[Tbl_Vendedor] ([rut], [nombre], [a_paterno], [a_materno], [direccion], [fono], [email], [fecha_ingreso], [region], [pais]) VALUES (N'16203321-2', N'Elias', N'Godoy', N'Velasquez', N'Talca 1856', N'+5693915960', N'elias.godoy.velasquez@gmail.com', CAST(N'2023-08-29' AS Date), 3, N'Chile')
GO
INSERT [dbo].[Tbl_Vendedor] ([rut], [nombre], [a_paterno], [a_materno], [direccion], [fono], [email], [fecha_ingreso], [region], [pais]) VALUES (N'8416560-3', N'Carlos', N'Godoy', N'Robles', N'Portezuelo del inca', N'+56998662443', N'cgodoy@gmail.com', CAST(N'2023-08-30' AS Date), 2, N'Chile')
GO
SET IDENTITY_INSERT [dbo].[Tbl_Ventas] ON 
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (2, N'8416560-3', 2500, 2, CAST(N'2022-10-10' AS Date), 1)
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (3, N'8416560-3', 2000, 3, CAST(N'2022-11-10' AS Date), 1)
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (10, N'16203321-2', 50000, 2, CAST(N'2022-10-10' AS Date), 1)
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (13, N'15972318-2', 56000, 2, CAST(N'2022-06-01' AS Date), 1)
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (14, N'15972318-2', 5000, 2, CAST(N'2022-10-10' AS Date), 1)
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (15, N'15972318-2', 90000, 2, CAST(N'2022-03-01' AS Date), 1)
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (16, N'15972318-2', 90000, 2, CAST(N'2022-06-01' AS Date), 1)
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (17, N'15972318-2', 9200, 2, CAST(N'2022-03-05' AS Date), 1)
GO
INSERT [dbo].[Tbl_Ventas] ([id_venta], [rut_vendedor], [monto], [margen], [fecha_venta], [id_usuario]) VALUES (18, N'15972318-2', 5000, 2, CAST(N'2022-03-01' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[Tbl_Ventas] OFF
GO
ALTER TABLE [dbo].[Tbl_TipoVenta]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_TipoVenta_Tbl_Comision] FOREIGN KEY([id_comision])
REFERENCES [dbo].[Tbl_Comision] ([id_comision])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_TipoVenta] CHECK CONSTRAINT [FK_Tbl_TipoVenta_Tbl_Comision]
GO
ALTER TABLE [dbo].[Tbl_Vendedor]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Vendedor_Tbl_Region] FOREIGN KEY([region])
REFERENCES [dbo].[Tbl_Region] ([cod_region])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_Vendedor] CHECK CONSTRAINT [FK_Tbl_Vendedor_Tbl_Region]
GO
ALTER TABLE [dbo].[Tbl_Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Ventas_Tbl_Comision] FOREIGN KEY([margen])
REFERENCES [dbo].[Tbl_Comision] ([id_comision])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_Ventas] CHECK CONSTRAINT [FK_Tbl_Ventas_Tbl_Comision]
GO
ALTER TABLE [dbo].[Tbl_Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Ventas_Tbl_Vendedor] FOREIGN KEY([rut_vendedor])
REFERENCES [dbo].[Tbl_Vendedor] ([rut])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_Ventas] CHECK CONSTRAINT [FK_Tbl_Ventas_Tbl_Vendedor]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarComision]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarComision]
@id_comision int,
@margen float,
@tipo_ventas varchar(50)
AS
BEGIN
	update Tbl_Comision set margen=@margen,tipo_ventas=@tipo_ventas where id_comision=@id_comision;
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarRegion]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActualizarRegion]
@cod_region int,
@descripcion varchar(50)
AS
BEGIN
	update Tbl_Region set descripcion=@descripcion where cod_region=@cod_region;
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarTipoVenta]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActualizarTipoVenta]
@id_comision int,
@margen float,
@tipo_ventas varchar(50)
AS
BEGIN
	update Tbl_TipoVenta set id_comision=@id_comision,margen=@margen,tipo_ventas=@tipo_ventas where id_comision=@id_comision;
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarVendedor]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarVendedor]
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
/****** Object:  StoredProcedure [dbo].[ActualizarVenta]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ActualizarVenta]
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
/****** Object:  StoredProcedure [dbo].[AgregarComision]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarComision]
@margen float,
@tipo_ventas varchar(50)
AS
BEGIN
	insert into Tbl_Comision(margen,tipo_ventas) values(@margen,@tipo_ventas);
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarRegion]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarRegion]
@cod_region int,
@descripcion varchar(50)
AS
BEGIN
	insert into Tbl_Region values(@cod_region,@descripcion);
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarTipoVenta]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarTipoVenta]
@id_comision int,
@margen float,
@tipo_ventas varchar(50)
AS
BEGIN
	insert into Tbl_TipoVenta values(@id_comision,@margen,@tipo_ventas);
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarVendedor]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarVendedor]
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
/****** Object:  StoredProcedure [dbo].[AgregarVenta]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarVenta]
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
/****** Object:  StoredProcedure [dbo].[EliminarComision]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarComision]
@id_comision int
AS
BEGIN
	delete from Tbl_Comision where id_comision=@id_comision;
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarRegion]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarRegion]
@cod_region int
AS
BEGIN
	delete from Tbl_Region where cod_region= @cod_region;
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarTipoVenta]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarTipoVenta]
@id_comision int
AS
BEGIN
	delete from Tbl_TipoVenta where id_comision=@id_comision;
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarVendedor]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarVendedor]
@rut varchar(50)
AS

BEGIN
	delete from Tbl_Vendedor where rut=@rut;
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarVenta]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarVenta]
@id_venta int
AS
BEGIN
	delete from Tbl_Ventas where id_venta=@id_venta;
END
GO
/****** Object:  StoredProcedure [dbo].[GetVendedoresPorRegion]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetVendedoresPorRegion]
@region varchar(30)
AS

BEGIN
	
	select 'vendedores' as '@id','vendedores' as '@name','form-control' as '@class',
	(
	select rut as '@value',nombre+'' from Tbl_Vendedor,Tbl_Region where region=cod_region and descripcion=@region FOR XML PATH('option'),TYPE
	)
	FOR XML PATH ('select'),ELEMENTS
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetVentasPorFecha]    Script Date: 31/08/2023 1:22:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetVentasPorFecha]
AS
BEGIN
	select vendedor.rut,vendedor.nombre,SUM(venta.monto) as total, SUM(venta.monto*comision.margen/100) as total_comision,venta.fecha_venta 
	from Tbl_Vendedor vendedor,Tbl_Ventas venta,Tbl_Comision comision,Tbl_Region region 
	where vendedor.rut=venta.rut_vendedor and comision.id_comision=venta.margen and region.cod_region=vendedor.region and 
	((MONTH(fecha_venta)=3 and YEAR(fecha_venta)=2022) or (MONTH(fecha_venta)=6 and YEAR(fecha_venta)=2022)) and 
	(region.descripcion='Metropolitana' or region.descripcion='Rancagua') group by vendedor.rut,vendedor.nombre,venta.fecha_venta order by vendedor.nombre,vendedor.rut,venta.fecha_venta asc;
END
GO
