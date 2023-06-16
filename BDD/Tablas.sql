



CREATE DATABASE proyecto_tallerII
GO
USE proyecto_tallerII
GO

/*ROLES */

CREATE TABLE rol(
IdRol INT PRIMARY KEY IDENTITY,
Descripcion VARCHAR (50),
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*PERMISOS */

CREATE TABLE permiso (
IdPermiso INT PRIMARY KEY IDENTITY,
IdRol INT REFERENCES rol(IdRol),
Nombre VARCHAR (100),
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*PROVEEDORES*/

CREATE TABLE proveedor(
IdProveedor INT PRIMARY KEY IDENTITY,
Documento VARCHAR(50),
RazonSocial VARCHAR(50),
Correo VARCHAR (50),
Telefono VARCHAR(50),
Estado BIT,
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*CLIENTES*/

CREATE TABLE cliente (
IdCliente INT PRIMARY KEY IDENTITY,
Documento VARCHAR(50),
NombreCompleto VARCHAR(70),
Correo VARCHAR (50),
Telefono VARCHAR (50),
Estado BIT,
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*USUARIOS*/
CREATE TABLE usuario (
IdUsuario INT PRIMARY KEY IDENTITY,
Documento VARCHAR(50),
NombreCompleto VARCHAR(70),
Correo VARCHAR (50),
IdRol INT REFERENCES rol(IdRol),
Clave VARCHAR (100),
Estado BIT,
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*CATEGORIA*/
CREATE TABLE categoria (
IdCategoria INT PRIMARY KEY IDENTITY,
Descripcion VARCHAR (50),
Estado BIT,
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*PRODUCTO*/
CREATE TABLE producto (
IdProducto INT PRIMARY KEY IDENTITY,
IdCategoria INT REFERENCES categoria(IdCategoria),
Nombre VARCHAR (50),
Codigo VARCHAR (50),
Descripcion VARCHAR (200),
Stock INT NOT NULL DEFAULT 0,
PrecioCompra DECIMAL(10,2) DEFAULT 0,
PrecioVenta DECIMAL (10,2) DEFAULT 0,
Estado BIT,
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*COMPRA*/
CREATE TABLE compra (
IdCompra INT PRIMARY KEY IDENTITY,
IdUsuario INT REFERENCES usuario(IdUsuario),
IdProveedor INT REFERENCES proveedor(IdProveedor),
TipoDocumento VARCHAR(50),
NumeroDocumento VARCHAR(50),
NombreCompleto VARCHAR(70),
MontoTotal DECIMAL(10,2),
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*DETALLE COMPRA*/
CREATE TABLE detalle_compra (
IdDetalleCompra INT PRIMARY KEY IDENTITY,
IdCompra INT REFERENCES compra(IdCompra),
IdProducto INT REFERENCES producto(IdProducto),
PrecioCompra DECIMAL(10,2) DEFAULT 0,
PrecioVenta DECIMAL (10,2) DEFAULT 0,
Cantidad INT,
MontoTotal DECIMAL(10,2),
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*VENTA */
CREATE TABLE venta (
IdVenta INT PRIMARY KEY IDENTITY,
IdUsuario INT REFERENCES usuario(IdUsuario),
TipoDocumento VARCHAR(50),
NumeroDocumento VARCHAR(50),
DocumentoCliente VARCHAR (50),
NombreCliente VARCHAR(100),
MontoPago DECIMAL(10,2),
MontoCambio DECIMAL(10,2),
MontoTotal DECIMAL(10,2),
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/*DETALLE VENTA*/
CREATE TABLE detalle_venta (
IdDetalleVenta INT PRIMARY KEY IDENTITY,
IdVenta INT REFERENCES venta(IdVenta),
IdProducto INT REFERENCES producto(IdProducto),
PrecioVenta DECIMAL (10,2),
Cantidad INT,
SubTotal DECIMAL(10,2),
FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

/* OTROS */

CREATE TABLE negocio (
IdNegocio INT PRIMARY KEY,
Nombre VARCHAR (50),
RUC VARCHAR (60),
Direccion VARCHAR (60),
Logo VARBINARY(MAX) NULL
)
GO











