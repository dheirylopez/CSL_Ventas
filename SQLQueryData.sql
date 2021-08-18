USE [CSL]
GO
SET IDENTITY_INSERT [dbo].[Almacen] ON 
GO
INSERT [dbo].[Almacen] ([Id], [IdItems], [IdUsuario], [IdProveedor], [Cantidad], [PrecioC], [PrecioV], [Fecha]) VALUES (1, 2, 1, 1, 2, 150, 300, CAST(N'2019-03-01T10:59:41.000' AS DateTime))
GO
INSERT [dbo].[Almacen] ([Id], [IdItems], [IdUsuario], [IdProveedor], [Cantidad], [PrecioC], [PrecioV], [Fecha]) VALUES (2, 1, 1, 1, 3, 500, 720, CAST(N'2019-03-02T10:11:43.000' AS DateTime))
GO
INSERT [dbo].[Almacen] ([Id], [IdItems], [IdUsuario], [IdProveedor], [Cantidad], [PrecioC], [PrecioV], [Fecha]) VALUES (3, 3, 1, 1, 2, 500, 700, CAST(N'2019-03-06T11:05:10.000' AS DateTime))
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
INSERT [dbo].[Conduce] ([Id], [IdCliente], [IdEmpleado], [IdFactura], [Fecha], [Observacion]) VALUES (4, 1, 1, 6, CAST(N'2019-03-08T09:14:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[Conduce] ([Id], [IdCliente], [IdEmpleado], [IdFactura], [Fecha], [Observacion]) VALUES (5, 1, 1, 6, CAST(N'2019-03-08T09:14:28.000' AS DateTime), NULL)
GO
INSERT [dbo].[Conduce] ([Id], [IdCliente], [IdEmpleado], [IdFactura], [Fecha], [Observacion]) VALUES (6, 1, 1, 9, CAST(N'2019-03-08T11:50:40.000' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Conduce] OFF
GO
SET IDENTITY_INSERT [dbo].[Cotizacion] ON 
GO
INSERT [dbo].[Cotizacion] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [Observacion], [Estatus]) VALUES (1, 1, 1, 43, 2160, 389, 2506, CAST(N'2019-03-02T10:54:56.000' AS DateTime), N'Importantes ', 1)
GO
INSERT [dbo].[Cotizacion] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [Observacion], [Estatus]) VALUES (2, 1, 1, 204, 2040, 367, 2203, CAST(N'2019-03-03T18:15:54.000' AS DateTime), N'Esta es una cotizacion de prueba para verificar que todo funciona bien.', 1)
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
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (4, 1, 1, 0, 0, 0, 0, CAST(N'2019-03-01T22:49:48.000' AS DateTime), N'A020010210100000006', N'', 0)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (5, 1, 1, 204, 2040, 367, 2203, CAST(N'2019-03-03T18:21:38.000' AS DateTime), N'A020010210100000006', N'Esta es una cotizacion de prueba para verificar que todo funciona bien.', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (6, 1, 1, 0, 3860, 695, 4555, CAST(N'2019-03-06T11:25:04.000' AS DateTime), N'A020010210100000008', N'Esta es De prueba', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (7, 1, 1, 0, 2000, 360, 2360, CAST(N'2019-03-06T13:32:36.000' AS DateTime), N'', N'', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (8, 1, 1, 0, 2000, 360, 2360, CAST(N'2019-03-06T13:33:34.000' AS DateTime), N'A020010210100000005', N'', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (9, 1, 1, 0, 2000, 360, 2360, CAST(N'2019-03-06T13:34:34.000' AS DateTime), N'A020010210100000006', N'', 1)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (10, 1, 1, 0, 0, 0, 0, CAST(N'2019-03-15T11:15:22.000' AS DateTime), N'', N'', 0)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (11, 1, 1, 0, 0, 0, 0, CAST(N'2019-03-15T11:19:54.000' AS DateTime), N'', N'', 0)
GO
INSERT [dbo].[Factura] ([Id], [IdCliente], [IdEmpleado], [Descuento], [SubTotal], [Itebis], [Total], [Fecha], [NCF], [Observacion], [Estatus]) VALUES (12, 1, 1, 0, 1400, 252, 1652, CAST(N'2019-03-15T11:28:58.000' AS DateTime), N'A020010210100000008', N'prueba nula', 0)
GO
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[HistoricoAlmacen] ON 
GO
INSERT [dbo].[HistoricoAlmacen] ([Id], [IdAlmacen], [Fecha], [Cantidad]) VALUES (1, 1, CAST(N'2019-03-01T10:59:41.000' AS DateTime), 2)
GO
INSERT [dbo].[HistoricoAlmacen] ([Id], [IdAlmacen], [Fecha], [Cantidad]) VALUES (2, 2, CAST(N'2019-03-02T10:11:43.000' AS DateTime), 10)
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
INSERT [dbo].[NCF] ([id], [Codigo], [Tipo], [Estatus], [FechaEmision], [FechaVencimiento], [FechaUso]) VALUES (4, N'A020010210100000005', N'Comprobantes para crédito fiscal', 0, CAST(N'2019-03-01T15:04:01.000' AS DateTime), CAST(N'2019-12-31T15:04:01.000' AS DateTime), CAST(N'2019-03-06T13:33:34.000' AS DateTime))
GO
INSERT [dbo].[NCF] ([id], [Codigo], [Tipo], [Estatus], [FechaEmision], [FechaVencimiento], [FechaUso]) VALUES (5, N'A020010210100000006', N'Comprobantes para crédito fiscal', 0, CAST(N'2019-03-01T15:04:28.000' AS DateTime), CAST(N'2019-03-01T15:04:28.000' AS DateTime), CAST(N'2019-03-06T13:34:34.000' AS DateTime))
GO
INSERT [dbo].[NCF] ([id], [Codigo], [Tipo], [Estatus], [FechaEmision], [FechaVencimiento], [FechaUso]) VALUES (6, N'A020010210100000008', N'Comprobantes para crédito fiscal', 1, CAST(N'2019-03-01T15:05:23.000' AS DateTime), CAST(N'2019-12-31T15:05:23.000' AS DateTime), CAST(N'2019-03-15T11:29:47.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[NCF] OFF
GO
INSERT [dbo].[PermisoUsuario] ([IdPermisoUsuario], [IdCompania], [IdUsuario], [Modulo], [PantallasMenu], [Permiso]) VALUES (1, 1, 1, N'Venta', N'MenuMantenimiento', N'X')
GO
INSERT [dbo].[PermisoUsuario] ([IdPermisoUsuario], [IdCompania], [IdUsuario], [Modulo], [PantallasMenu], [Permiso]) VALUES (1, 1, 1, N'Venta', N'MenuOperaciones', N'X')
GO
INSERT [dbo].[PermisoUsuario] ([IdPermisoUsuario], [IdCompania], [IdUsuario], [Modulo], [PantallasMenu], [Permiso]) VALUES (1, 1, 1, N'Venta', N'SubMenuFormCompania', N'X')
GO
INSERT [dbo].[PermisoUsuario] ([IdPermisoUsuario], [IdCompania], [IdUsuario], [Modulo], [PantallasMenu], [Permiso]) VALUES (1, 1, 1, N'Venta', N'SubMenuFormCompania', N'X')
GO
INSERT [dbo].[PermisoUsuario] ([IdPermisoUsuario], [IdCompania], [IdUsuario], [Modulo], [PantallasMenu], [Permiso]) VALUES (1, 1, 1, N'Venta', N'SubMenuCompania', N'X')
GO
INSERT [dbo].[PermisoUsuario] ([IdPermisoUsuario], [IdCompania], [IdUsuario], [Modulo], [PantallasMenu], [Permiso]) VALUES (1, 1, 1, N'Ventas', N'SubSubMenuFormSucursal', N'X')
GO
INSERT [dbo].[PermisoUsuario] ([IdPermisoUsuario], [IdCompania], [IdUsuario], [Modulo], [PantallasMenu], [Permiso]) VALUES (1, 1, 1, N'Ventas', N'SubMenuFormConduce', N'L')
GO
INSERT [dbo].[PermisoUsuario] ([IdPermisoUsuario], [IdCompania], [IdUsuario], [Modulo], [PantallasMenu], [Permiso]) VALUES (1, 1, 1, N'Ventas', N'SubSubMenuFormHistoricoConduce', N'')
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
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (1, 1, NULL, N'SubMenuFormEmpleados')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (2, 1, NULL, N'SubMenuFormClientes')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (3, 1, NULL, N'SubMenuFormProveedores')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (4, 1, NULL, N'SubMenuFormCompania')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (5, 1, NULL, N'SubSubMenuFormComprobanteFiscal')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (6, 2, NULL, N'SubMenuFormFacturacion')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (7, 2, NULL, N'SubSubMenuFormHistoricoFacturacion')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (8, 2, NULL, N'SubMenuFormCotizacion')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (9, 2, NULL, N'SubSubMenuFormHistoricoCotizacion')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (10, 2, NULL, N'SubMenuFormConduce')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (11, 2, NULL, N'SubSubMenuFormHistoricoConduce')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (12, 3, NULL, N'SubMenuFormArticulo')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (13, 3, NULL, N'SubMenuFormIngresoAlmacen')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (14, 3, NULL, N'SubMenuFormInventario')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (15, 4, NULL, N'SubMenuReporteVenta')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (16, 4, NULL, N'SubMenuReporteGananciaPerdida')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (17, 1, NULL, N'SubSubMenuFormSucursal')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (18, 1, NULL, N'SubSubMenuFormCompania')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (19, 1, NULL, N'MenuMantenimiento')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (20, 2, NULL, N'MenuOperaciones')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (21, 3, NULL, N'MenuAlmacen')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (22, 4, NULL, N'MenuReporte')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (23, 2, NULL, N'SubSubMenuFormFacturacion')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (24, 2, NULL, N'SubSubMenuFormCotizacion')
GO
INSERT [dbo].[SubMenu] ([IdSubmenu], [IdMenu], [posicion], [nombre]) VALUES (25, 2, NULL, N'SubSubMenuFormConduce')
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([Id], [IdEmpleado], [Clave], [Rol], [Estatus]) VALUES (1, 1, 9406, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
