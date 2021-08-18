USE [Decoraciones_delacruz]
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Almacen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdItems] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioC] [int] NOT NULL,
	[PrecioV] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AreasSegura]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AreasSegura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[TipoD] [varchar](30) NOT NULL,
	[NDocumento] [varchar](13) NOT NULL,
	[Telefono] [varchar](12) NOT NULL,
	[Direccion] [varchar](250) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Conduce]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conduce](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[IdFactura] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Observacion] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cotizacion]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cotizacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Descuento] [int] NOT NULL,
	[SubTotal] [int] NOT NULL,
	[Itebis] [int] NULL,
	[Total] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Observacion] [text] NOT NULL,
	[Estatus] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleConduce]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleConduce](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdConduce] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleCotizacion]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCotizacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCotizacion] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioU] [int] NOT NULL,
	[Itebi] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdFactura] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioU] [int] NOT NULL,
	[Itebi] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[TipoD] [varchar](30) NOT NULL,
	[NDocumento] [varchar](13) NOT NULL,
	[Telefono] [varchar](12) NOT NULL,
	[Direccion] [varchar](250) NULL,
	[Puesto] [varchar](100) NULL,
	[Sueldo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Factura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Descuento] [int] NOT NULL,
	[SubTotal] [int] NOT NULL,
	[Itebis] [int] NULL,
	[Total] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[NCF] [varchar](50) NOT NULL,
	[Observacion] [text] NULL,
	[Estatus] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HistoricoAlmacen]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoricoAlmacen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Tipo] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NCF]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NCF](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](19) NOT NULL,
	[Tipo] [varchar](200) NOT NULL,
	[Estatus] [int] NOT NULL,
	[FechaEmision] [datetime] NOT NULL,
	[FechaVencimiento] [datetime] NOT NULL,
	[FechaUso] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[TipoD] [varchar](30) NOT NULL,
	[NDocumento] [varchar](13) NOT NULL,
	[Telefono] [varchar](12) NOT NULL,
	[Direccion] [varchar](250) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RolesAreas]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolesAreas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NOT NULL,
	[IdArea] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Clave] [int] NOT NULL,
	[Rol] [int] NOT NULL,
	[Estatus] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_Conduce]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Conduce]
AS
SELECT        dbo.DetalleConduce.Id, dbo.Conduce.Id AS IdConduce, dbo.Empleado.Nombre AS Empleado, dbo.Items.Nombre AS Articulo, dbo.DetalleConduce.Cantidad, dbo.Conduce.IdFactura, dbo.Conduce.Fecha, 
                         dbo.Conduce.Observacion, dbo.Cliente.Nombre AS Cliente, dbo.Cliente.Direccion, dbo.Cliente.Telefono
FROM            dbo.Conduce INNER JOIN
                         dbo.DetalleConduce ON dbo.Conduce.Id = dbo.DetalleConduce.IdConduce INNER JOIN
                         dbo.Empleado ON dbo.Conduce.IdEmpleado = dbo.Empleado.Id INNER JOIN
                         dbo.Items ON dbo.DetalleConduce.IdArticulo = dbo.Items.Id INNER JOIN
                         dbo.Cliente ON dbo.Conduce.IdCliente = dbo.Cliente.Id

GO
/****** Object:  View [dbo].[View_Cotizacion]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Cotizacion]
AS
SELECT        dbo.Cotizacion.Id, dbo.DetalleCotizacion.Id AS idDetalle, dbo.Items.Nombre AS Articulo, dbo.DetalleCotizacion.Cantidad, dbo.DetalleCotizacion.PrecioU AS Precio, dbo.DetalleCotizacion.Itebi, 
                         dbo.Cotizacion.Descuento, dbo.Cotizacion.SubTotal, dbo.Cotizacion.Itebis, dbo.Cotizacion.Total, dbo.Cotizacion.Fecha, dbo.Cotizacion.Observacion, dbo.Empleado.Nombre AS Colaborador, 
                         dbo.Cliente.Nombre AS Cliente
FROM            dbo.DetalleCotizacion INNER JOIN
                         dbo.Cotizacion ON dbo.DetalleCotizacion.IdCotizacion = dbo.Cotizacion.Id INNER JOIN
                         dbo.Items ON dbo.DetalleCotizacion.IdArticulo = dbo.Items.Id INNER JOIN
                         dbo.Empleado ON dbo.Cotizacion.IdEmpleado = dbo.Empleado.Id INNER JOIN
                         dbo.Cliente ON dbo.Cotizacion.IdCliente = dbo.Cliente.Id


GO
/****** Object:  View [dbo].[View_Factura]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Factura]
AS
SELECT        dbo.Factura.Id, dbo.DetalleFactura.Id AS IdDetalle, dbo.Empleado.Nombre AS Empleado, dbo.Cliente.Nombre AS Cliente, dbo.Factura.Descuento, dbo.Factura.SubTotal, dbo.Factura.Itebis, dbo.Factura.Total, 
                         dbo.Factura.Fecha, dbo.Items.Nombre AS Articulo, dbo.DetalleFactura.PrecioU AS Precio, dbo.DetalleFactura.Cantidad, dbo.Factura.NCF, dbo.Factura.Observacion
FROM            dbo.DetalleFactura INNER JOIN
                         dbo.Factura ON dbo.DetalleFactura.IdFactura = dbo.Factura.Id INNER JOIN
                         dbo.Empleado ON dbo.Factura.IdEmpleado = dbo.Empleado.Id INNER JOIN
                         dbo.Items ON dbo.DetalleFactura.IdArticulo = dbo.Items.Id INNER JOIN
                         dbo.Cliente ON dbo.Factura.IdCliente = dbo.Cliente.Id


GO
/****** Object:  View [dbo].[View_Ganancias_Gastos]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Ganancias_Gastos]
AS
SELECT        dbo.DetalleFactura.Id, dbo.Factura.Id AS idFactura, dbo.DetalleFactura.Cantidad, dbo.DetalleFactura.PrecioU, dbo.Items.Nombre, dbo.Almacen.PrecioC, dbo.Factura.Fecha
FROM            dbo.Factura INNER JOIN
                         dbo.DetalleFactura ON dbo.Factura.Id = dbo.DetalleFactura.IdFactura INNER JOIN
                         dbo.Items ON dbo.DetalleFactura.IdArticulo = dbo.Items.Id INNER JOIN
                         dbo.Almacen ON dbo.DetalleFactura.IdArticulo = dbo.Almacen.IdItems

GO
/****** Object:  View [dbo].[View_Inventario]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Inventario]
AS
SELECT        dbo.Almacen.Id, dbo.Empleado.Nombre AS Colaborador, dbo.Items.Nombre AS Articulo, dbo.Proveedor.Nombre AS Proveedor, dbo.Almacen.Cantidad, dbo.Almacen.PrecioC, dbo.Almacen.PrecioV, 
                         dbo.Almacen.Fecha
FROM            dbo.Almacen INNER JOIN
                         dbo.Items ON dbo.Almacen.IdItems = dbo.Items.Id INNER JOIN
                         dbo.Empleado ON dbo.Almacen.IdUsuario = dbo.Empleado.Id INNER JOIN
                         dbo.Proveedor ON dbo.Almacen.IdProveedor = dbo.Proveedor.Id



GO
/****** Object:  View [dbo].[View_VentaEmpleado]    Script Date: 16/03/2019 9:54:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_VentaEmpleado]
AS
SELECT        dbo.Factura.Id, dbo.Empleado.Nombre AS Colaborador, dbo.Cliente.Nombre AS Cliente, dbo.Factura.Observacion, dbo.Factura.Descuento, dbo.Factura.SubTotal, dbo.Factura.Fecha
FROM            dbo.Factura INNER JOIN
                         dbo.Empleado ON dbo.Factura.IdEmpleado = dbo.Empleado.Id INNER JOIN
                         dbo.Cliente ON dbo.Factura.IdCliente = dbo.Cliente.Id CROSS JOIN
                         dbo.Items


GO
SET IDENTITY_INSERT [dbo].[Almacen] ON 

GO
INSERT [dbo].[Almacen] ([Id], [IdItems], [IdUsuario], [IdProveedor], [Cantidad], [PrecioC], [PrecioV], [Fecha]) VALUES (1, 2, 1, 1, 2, 150, 300, CAST(N'2019-03-01 10:59:41.000' AS DateTime))
GO
INSERT [dbo].[Almacen] ([Id], [IdItems], [IdUsuario], [IdProveedor], [Cantidad], [PrecioC], [PrecioV], [Fecha]) VALUES (2, 1, 1, 1, 3, 500, 720, CAST(N'2019-03-02 10:11:43.000' AS DateTime))
GO
INSERT [dbo].[Almacen] ([Id], [IdItems], [IdUsuario], [IdProveedor], [Cantidad], [PrecioC], [PrecioV], [Fecha]) VALUES (3, 3, 1, 1, 2, 500, 700, CAST(N'2019-03-06 11:05:10.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Almacen] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

GO
INSERT [dbo].[Cliente] ([Id], [Nombre], [TipoD], [NDocumento], [Telefono], [Direccion], [Email]) VALUES (1, N'Dheiry Lopez', N'RNC', N'3141801', N'809-456-1586', N'Av.Los restauradores', N'dheirylopez@gmail.com')
GO
INSERT [dbo].[Cliente] ([Id], [Nombre], [TipoD], [NDocumento], [Telefono], [Direccion], [Email]) VALUES (3, N'Joel Feliz', N'Cedula', N'225-0082886-2', N'809-859-5845', N'Yamasa', N'joel.feliz@hotmail.com')
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Conduce] ON 

GO
INSERT [dbo].[Conduce] ([Id], [IdCliente], [IdEmpleado], [IdFactura], [Fecha], [Observacion]) VALUES (4, 1, 1, 6, CAST(N'2019-03-08 09:14:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[Conduce] ([Id], [IdCliente], [IdEmpleado], [IdFactura], [Fecha], [Observacion]) VALUES (5, 1, 1, 6, CAST(N'2019-03-08 09:14:28.000' AS DateTime), NULL)
GO
INSERT [dbo].[Conduce] ([Id], [IdCliente], [IdEmpleado], [IdFactura], [Fecha], [Observacion]) VALUES (6, 1, 1, 9, CAST(N'2019-03-08 11:50:40.000' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Conduce] OFF
GO
SET IDENTITY_INSERT [dbo].[Cotizacion] ON 

GO
INSERT [dbo].[Cotizacion] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [Observacion], [Estatus]) VALUES (1, 1, 1, 43, 2160, 389, 2506, CAST(N'2019-03-02 10:54:56.000' AS DateTime), N'Importantes ', 1)
GO
INSERT [dbo].[Cotizacion] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [Observacion], [Estatus]) VALUES (2, 1, 1, 204, 2040, 367, 2203, CAST(N'2019-03-03 18:15:54.000' AS DateTime), N'Esta es una cotizacion de prueba para verificar que todo funciona bien.', 1)
GO
SET IDENTITY_INSERT [dbo].[Cotizacion] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleConduce] ON 

GO
INSERT [dbo].[DetalleConduce] ([Id], [IdConduce], [IdArticulo], [Cantidad]) VALUES (7, 4, 2, 1)
GO
INSERT [dbo].[DetalleConduce] ([Id], [IdConduce], [IdArticulo], [Cantidad]) VALUES (8, 5, 3, 2)
GO
INSERT [dbo].[DetalleConduce] ([Id], [IdConduce], [IdArticulo], [Cantidad]) VALUES (9, 5, 1, 3)
GO
INSERT [dbo].[DetalleConduce] ([Id], [IdConduce], [IdArticulo], [Cantidad]) VALUES (10, 6, 2, 2)
GO
INSERT [dbo].[DetalleConduce] ([Id], [IdConduce], [IdArticulo], [Cantidad]) VALUES (11, 6, 3, 2)
GO
SET IDENTITY_INSERT [dbo].[DetalleConduce] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleCotizacion] ON 

GO
INSERT [dbo].[DetalleCotizacion] ([Id], [IdCotizacion], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (1, 1, 1, 2, 720, 259.2)
GO
INSERT [dbo].[DetalleCotizacion] ([Id], [IdCotizacion], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (2, 1, 1, 1, 720, 129.6)
GO
INSERT [dbo].[DetalleCotizacion] ([Id], [IdCotizacion], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (3, 2, 1, 2, 720, 259.2)
GO
INSERT [dbo].[DetalleCotizacion] ([Id], [IdCotizacion], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (4, 2, 2, 2, 300, 108)
GO
SET IDENTITY_INSERT [dbo].[DetalleCotizacion] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleFactura] ON 

GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (9, 4, 2, 1, 300, 54)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (10, 5, 1, 2, 720, 259.2)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (11, 5, 2, 2, 300, 108)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (12, 6, 3, 2, 700, 252)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (13, 6, 2, 1, 300, 54)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (14, 6, 1, 3, 720, 388.8)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (15, 9, 2, 2, 300, 108)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (16, 9, 3, 2, 700, 252)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (17, 10, 1, 2, 720, 259.2)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (18, 11, 2, 1, 300, 54)
GO
INSERT [dbo].[DetalleFactura] ([Id], [IdFactura], [IdArticulo], [Cantidad], [PrecioU], [Itebi]) VALUES (19, 12, 3, 2, 700, 252)
GO
SET IDENTITY_INSERT [dbo].[DetalleFactura] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [TipoD], [NDocumento], [Telefono], [Direccion], [Puesto], [Sueldo]) VALUES (1, N'Dheiry Lopez', N'Cedula', N'225-0082886-2', N'809-456-8158', N'Av.Los Restauradores #2', N'Programador', 0)
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [TipoD], [NDocumento], [Telefono], [Direccion], [Puesto], [Sueldo]) VALUES (2, N'Yamilka Lopez', N'Cedula', N'225-0015487-9', N'809-856-8559', N'villa mella', N'empleada', 2)
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [TipoD], [NDocumento], [Telefono], [Direccion], [Puesto], [Sueldo]) VALUES (3, N'Lorenny Santana', N'Cedula', N'123-8569898-5', N'809-456-8498', N'samana', N'empleada', 2000)
GO
INSERT [dbo].[Empleado] ([Id], [Nombre], [TipoD], [NDocumento], [Telefono], [Direccion], [Puesto], [Sueldo]) VALUES (4, N'Lorenny', N'Cedula', N'225-0082886-2', N'809-568-8458', N'sabana perdida', N'vendedora', 0)
GO
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 

GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (4, 1, 1, 0, 0, 0, 0, CAST(N'2019-03-01 22:49:48.000' AS DateTime), N'A020010210100000006', N'', 0)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (5, 1, 1, 204, 2040, 367, 2203, CAST(N'2019-03-03 18:21:38.000' AS DateTime), N'A020010210100000006', N'Esta es una cotizacion de prueba para verificar que todo funciona bien.', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (6, 1, 1, 0, 3860, 695, 4555, CAST(N'2019-03-06 11:25:04.000' AS DateTime), N'A020010210100000008', N'Esta es De prueba', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (7, 1, 1, 0, 2000, 360, 2360, CAST(N'2019-03-06 13:32:36.000' AS DateTime), N'', N'', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (8, 1, 1, 0, 2000, 360, 2360, CAST(N'2019-03-06 13:33:34.000' AS DateTime), N'A020010210100000005', N'', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (9, 1, 1, 0, 2000, 360, 2360, CAST(N'2019-03-06 13:34:34.000' AS DateTime), N'A020010210100000006', N'', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (10, 1, 1, 0, 0, 0, 0, CAST(N'2019-03-15 11:15:22.000' AS DateTime), N'', N'', 0)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (11, 1, 1, 0, 0, 0, 0, CAST(N'2019-03-15 11:19:54.000' AS DateTime), N'', N'', 0)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (12, 1, 1, 0, 1400, 252, 1652, CAST(N'2019-03-15 11:28:58.000' AS DateTime), N'A020010210100000008', N'prueba nula', 0)
GO
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[HistoricoAlmacen] ON 

GO
INSERT [dbo].[HistoricoAlmacen] ([Id], [IdAlmacen], [Fecha], [Cantidad]) VALUES (1, 1, CAST(N'2019-03-01 10:59:41.000' AS DateTime), 2)
GO
INSERT [dbo].[HistoricoAlmacen] ([Id], [IdAlmacen], [Fecha], [Cantidad]) VALUES (2, 2, CAST(N'2019-03-02 10:11:43.000' AS DateTime), 10)
GO
SET IDENTITY_INSERT [dbo].[HistoricoAlmacen] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

GO
INSERT [dbo].[Items] ([Id], [Nombre], [Tipo]) VALUES (1, N'Estatua', N'Creado')
GO
INSERT [dbo].[Items] ([Id], [Nombre], [Tipo]) VALUES (2, N'Marco', N'Creado')
GO
INSERT [dbo].[Items] ([Id], [Nombre], [Tipo]) VALUES (3, N'Tarro-de 75', N'Creado')
GO
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[NCF] ON 

GO
INSERT [dbo].[NCF] ([id], [Codigo], [Tipo], [Estatus], [FechaEmision], [FechaVencimiento], [FechaUso]) VALUES (4, N'A020010210100000005', N'Comprobantes para crédito fiscal', 0, CAST(N'2019-03-01 15:04:01.000' AS DateTime), CAST(N'2019-12-31 15:04:01.000' AS DateTime), CAST(N'2019-03-06 13:33:34.000' AS DateTime))
GO
INSERT [dbo].[NCF] ([id], [Codigo], [Tipo], [Estatus], [FechaEmision], [FechaVencimiento], [FechaUso]) VALUES (5, N'A020010210100000006', N'Comprobantes para crédito fiscal', 0, CAST(N'2019-03-01 15:04:28.000' AS DateTime), CAST(N'2019-03-01 15:04:28.000' AS DateTime), CAST(N'2019-03-06 13:34:34.000' AS DateTime))
GO
INSERT [dbo].[NCF] ([id], [Codigo], [Tipo], [Estatus], [FechaEmision], [FechaVencimiento], [FechaUso]) VALUES (6, N'A020010210100000008', N'Comprobantes para crédito fiscal', 1, CAST(N'2019-03-01 15:05:23.000' AS DateTime), CAST(N'2019-12-31 15:05:23.000' AS DateTime), CAST(N'2019-03-15 11:29:47.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[NCF] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

GO
INSERT [dbo].[Proveedor] ([Id], [Nombre], [TipoD], [NDocumento], [Telefono], [Direccion], [Email]) VALUES (1, N'CreateSoft', N'RNC', N'13104186', N'809-409-8158', N'Av.Los restauradores Km 1 1/2', N'createsoftlopez@gmail.com')
GO
INSERT [dbo].[Proveedor] ([Id], [Nombre], [TipoD], [NDocumento], [Telefono], [Direccion], [Email]) VALUES (3, N'michel', N'Cedula', N'225-858659-5', N'829-753-1548', N'Samana', N'michel@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

GO
INSERT [dbo].[Roles] ([Id], [Nombre]) VALUES (1, N'Admin')
GO
INSERT [dbo].[Roles] ([Id], [Nombre]) VALUES (2, N'Empleado')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

GO
INSERT [dbo].[Usuario] ([Id], [IdEmpleado], [Clave], [Rol], [Estatus]) VALUES (1, 1, 9406, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[54] 4[5] 2[42] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Conduce"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 174
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DetalleConduce"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 149
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Empleado"
            Begin Extent = 
               Top = 175
               Left = 251
               Bottom = 305
               Right = 421
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Items"
            Begin Extent = 
               Top = 40
               Left = 451
               Bottom = 153
               Right = 621
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 178
               Left = 31
               Bottom = 350
               Right = 201
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Conduce'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Conduce'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Conduce'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[62] 4[5] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DetalleCotizacion"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 198
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cotizacion"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 210
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Empleado"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 152
               Left = 449
               Bottom = 282
               Right = 619
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Items"
            Begin Extent = 
               Top = 221
               Left = 236
               Bottom = 334
               Right = 406
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
       ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Cotizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'  Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Cotizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Cotizacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[57] 4[5] 2[33] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DetalleFactura"
            Begin Extent = 
               Top = 9
               Left = 204
               Bottom = 168
               Right = 374
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Factura"
            Begin Extent = 
               Top = 11
               Left = 419
               Bottom = 264
               Right = 593
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Empleado"
            Begin Extent = 
               Top = 28
               Left = 615
               Bottom = 158
               Right = 785
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Items"
            Begin Extent = 
               Top = 90
               Left = 7
               Bottom = 203
               Right = 177
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 160
               Left = 621
               Bottom = 290
               Right = 791
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or =' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Factura'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Factura'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Factura'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[53] 4[2] 2[27] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Factura"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 265
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "DetalleFactura"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 192
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Almacen"
            Begin Extent = 
               Top = 1
               Left = 453
               Bottom = 214
               Right = 623
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Items"
            Begin Extent = 
               Top = 13
               Left = 627
               Bottom = 126
               Right = 797
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Ganancias_Gastos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Ganancias_Gastos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[64] 4[5] 2[14] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Almacen"
            Begin Extent = 
               Top = 10
               Left = 192
               Bottom = 215
               Right = 362
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Items"
            Begin Extent = 
               Top = 8
               Left = 387
               Bottom = 169
               Right = 557
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Empleado"
            Begin Extent = 
               Top = 190
               Left = 396
               Bottom = 320
               Right = 566
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Proveedor"
            Begin Extent = 
               Top = 113
               Left = 7
               Bottom = 243
               Right = 177
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Inventario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Inventario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[58] 4[4] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Factura"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 268
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Empleado"
            Begin Extent = 
               Top = 145
               Left = 240
               Bottom = 275
               Right = 410
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Items"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 119
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_VentaEmpleado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_VentaEmpleado'
GO
