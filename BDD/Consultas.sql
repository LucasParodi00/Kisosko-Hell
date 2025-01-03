


SELECT * FROM usuario;
GO
SELECT * FROM rol;
GO
SELECT * FROM permiso WHERE IdRol = 1;
GO
SELECT * FROM categoria;
GO
SELECT * FROM producto;
GO
SELECT IdCategoria, Descripcion, Estado FROM categoria

SELECT  producto.IdProducto, producto.Codigo, categoria.IdCategoria, categoria.Descripcion[DescripcionCategoria], producto.Nombre,  producto.Codigo, producto.Descripcion,  producto.Stock,  producto.PrecioCompra,  producto.PrecioVenta, producto.Estado FROM producto
JOIN categoria ON categoria.IdCategoria = producto.IdCategoria

INSERT INTO producto (Codigo, Nombre, Descripcion, IdCategoria, Estado) VALUES ('VFD-001', 'Harry Potter', 'Volumen 3', 13, 1)

UPDATE producto SET Estado = 1 WHERE IdProducto = 7


SELECT IdCliente, NombreCompleto, Correo, Telefono, Estado FROM cliente
SELECT * FROM cliente

SELECT IdCliente, NombreCompleto, Correo, Telefono, Estado, FechaRegistro FROM cliente

INSERT INTO cliente (Documento, NombreCompleto, Correo, Telefono, Estado) VALUES ('51144754', 'Karen', 'dsdsd', '32321', 1)

GO

SELECT IdProveedor, Documento, RazonSocial, Correo, Telefono, Estado FROM proveedor

SELECT IdNegocio, Nombre, RUC, Direccion FROM negocio WHERE IdNegocio = 1

SELECT Logo FROM negocio WHERE IdNegocio = 1

SELECT * FROM negocio

SELECT * FROM compra

SELECT compra.IdCompra, usuario.NombreCompleto, proveedor.Documento, proveedor.RazonSocial, compra.TipoDocumento, compra.NumeroDocumento,
compra.MontoTotal, CONVERT(CHAR(10), compra.FechaRegistro, 3)[FechaRegistro] FROM compra
JOIN usuario ON usuario.IdUsuario = compra.IdUsuario
JOIN proveedor ON proveedor.IdProveedor = compra.IdProveedor
WHERE compra.NumeroDocumento = '00005'

GO

SELECT producto.Nombre, detalle_compra.PrecioCompra, detalle_compra.Cantidad, detalle_compra.MontoTotal FROM detalle_compra 
JOIN producto ON producto.IdProducto = detalle_compra.IdProducto
WHERE detalle_compra.IdCompra = 4
GO

UPDATE producto SET Stock = Stock - @Cantidad WHERE @IdProducto = IdProducto


SELECT * FROM compra

SELECT 
CONVERT(char(10), compra.FechaRegistro, 103)[FechaRegistro], compra.TipoDocumento, compra.NumeroDocumento, compra.MontoTotal,
usuario.NombreCompleto[UsuarioRegistro],
proveedor.Documento[DocumentoProveedor], proveedor.RazonSocial,
producto.Codigo[CodigoProducto], producto.Nombre[NombreProducto],
categoria.Descripcion[Categoria], detalle_compra.PrecioCompra, detalle_compra.PrecioVenta, detalle_compra.Cantidad, detalle_compra.MontoTotal[SubTotal]

FROM compra 
JOIN usuario ON usuario.IdUsuario = compra.IdUsuario
JOIN proveedor ON proveedor.IdProveedor = compra.IdProveedor
JOIN detalle_compra ON detalle_compra.IdCompra = compra.IdCompra
JOIN producto ON producto.IdProducto = detalle_compra.IdProducto
JOIN categoria ON categoria.IdCategoria = producto.IdCategoria
WHERE CONVERT(DATE, compra.FechaRegistro) BETWEEN '15/06/2023' AND '17/06/2023'




SELECT venta.IdVenta, usuario.NombreCompleto, venta.DocumentoCliente, venta.NombreCliente, venta.TipoDocumento,
	   venta.NumeroDocumento, venta.MontoPago, venta.MontoCambio, venta.MontoTotal, CONVERT(CHAR(10), venta.FechaRegistro, 103)[FechaRegistro]
FROM venta
JOIN usuario ON usuario.IdUsuario = venta.IdUsuario
WHERE venta.NumeroDocumento = venta.NumeroDocumento

     

SELECT producto.Nombre, detalle_venta.PrecioVenta, detalle_venta.Cantidad, detalle_venta.SubTotal FROM detalle_venta
JOIN producto ON producto.IdProducto = detalle_venta.IdProducto
WHERE detalle_venta.IdVenta = @IdVenta

SELECT * FROM cliente

UPDATE cliente SET Telefono = REPLACE(Telefono, SUBSTRING(Telefono, 1, 4), '3795') WHERE IdCliente > 100