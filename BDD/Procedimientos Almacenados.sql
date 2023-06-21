

 /* USUARIOS */
CREATE PROC SP_RegistrarUsuario (

@Documento VARCHAR (50),
@NombreCompleto VARCHAR (70),
@Correo VARCHAR (50),
@Clave VARCHAR (100),
@IdRol INT,
@Estado BIT,
@IdUsuarioResultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN 
		SET @IdUsuarioResultado = 0

		IF NOT EXISTS (SELECT * FROM usuario WHERE Documento = @Documento)
		BEGIN 
			INSERT INTO usuario( Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
			VALUES 
			(@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado)

			SET @IdUsuarioResultado = SCOPE_IDENTITY()
			SET @Mensaje = ''
		END
		ELSE 
			SET @Mensaje = 'El usuario ya esta registrado'
	END
GO


CREATE PROC SP_EditarUsuario (
@IdUsuario INT,
@Documento VARCHAR (50),
@NombreCompleto VARCHAR (70),
@Correo VARCHAR (50),
@Clave VARCHAR (100),
@IdRol INT,
@Estado BIT,
@Respuesta BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN 
		SET @Respuesta = 0

		IF NOT EXISTS (SELECT * FROM usuario WHERE Documento = @Documento AND IdUsuario != @IdUsuario)
		BEGIN 
			UPDATE usuario SET
			Documento = @Documento,
			NombreCompleto = @NombreCompleto,
			Correo = @Correo,
			Clave = @Clave,
			IdRol = @IdRol,
			Estado = @Estado
			WHERE @IdUsuario = IdUsuario
			SET @Respuesta = 1
			SET @Mensaje = ''
		END
		ELSE 
			SET @Mensaje = 'El usuario ya esta registrado'
	END
GO

CREATE PROC SP_EliminarUsuario (
@IdUsuario INT,
@Respuesta BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN 
		SET @Respuesta = 0
		DECLARE @PasoReglas BIT = 1

		IF EXISTS (SELECT * FROM compra 
		JOIN usuario ON usuario.IdUsuario = compra.IdUsuario
		WHERE compra.IdUsuario = @IdUsuario
		)
		BEGIN 
			SET @Respuesta = 0
			SET @PasoReglas = 0
			SET @Mensaje = @Mensaje + 'No se peude eliminar porque el usuario realizo una compra\n'
		END

		IF EXISTS (SELECT * FROM venta 
		JOIN usuario ON usuario.IdUsuario = venta.IdUsuario
		WHERE venta.IdUsuario = @IdUsuario
		)
		BEGIN 
			SET @Respuesta = 0
			SET @PasoReglas = 0
			SET @Mensaje = @Mensaje + 'No se peude eliminar porque el usuario realizo una venta\n'
		END

		IF (@PasoReglas = 1)
		BEGIN 
			DELETE usuario WHERE IdUsuario = @IdUsuario
			SET @Respuesta = 1
		END 
	END
GO

SELECT * FROM usuario
GO



/*CATEGORIAS*/

CREATE PROCEDURE SP_RegistrarCategoria (
@Descripcion VARCHAR (50),
@Estado BIT,
@Resultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS 
	BEGIN
		SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM categoria WHERE Descripcion = @Descripcion)
			BEGIN 
				INSERT INTO categoria (Descripcion, Estado) VALUES (@Descripcion, @Estado)
				SET @Resultado = SCOPE_IDENTITY() /*ULTIMO ID REGISTRADO*/
				SET @Mensaje = 'Categoria registrada correctamente' 
			END
		ELSE 
			SET @Mensaje = 'Ya existe esa categoria' 
	END
GO

CREATE PROCEDURE SP_ModificarCategoria (
@IdCategoria INT,
@Descripcion VARCHAR (50),
@Estado BIT,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS 
	BEGIN
		SET @Resultado = 1
		IF NOT EXISTS (SELECT * FROM categoria WHERE Descripcion = @Descripcion AND IdCategoria != @IdCategoria)
			BEGIN 
				UPDATE categoria SET
					Descripcion = @Descripcion,
					Estado = @Estado
					WHERE IdCategoria = @IdCategoria
			END
		ELSE 
			BEGIN
			SET @Resultado = 0
			SET @Mensaje = 'Ya existe esa categoria'
			END
	END
 GO

 CREATE PROCEDURE SP_EliminarCategoria (
 @IdCategoria INT,
 @Resultado BIT OUTPUT,
 @Mensaje VARCHAR (500) OUTPUT
 )
 AS
	BEGIN 
		SET @Resultado = 1
		IF NOT EXISTS (SELECT * FROM categoria
						JOIN producto ON categoria.IdCategoria = producto.IdCategoria
						WHERE categoria.IdCategoria = @IdCategoria)
		BEGIN
			DELETE FROM categoria WHERE IdCategoria = @IdCategoria
		END
		ELSE
			BEGIN 
				SET @Resultado = 0
				SET @Mensaje = 'No se puede eliminar esta categoria'
			END

	END
GO


/* PRODUCTOS */

CREATE PROCEDURE SP_RegistrarProducto(
@Codigo VARCHAR (20),
@Nombre VARCHAR (30),
@Descripcion VARCHAR (30),
@IdCategoria INT,
@Estado BIT,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN 
		SET @Resultado = 0
		IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo)
		BEGIN 
			INSERT INTO producto (Codigo, Nombre, Descripcion, IdCategoria, Estado ) 
			VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado)
			SET @Resultado = SCOPE_IDENTITY()
		END 
		ELSE
			SET @Mensaje = 'Ya existe un producto con ese codigo' 
	END 
GO

CREATE PROCEDURE SP_ModificarProducto(
@IdProducto INT,
@Codigo VARCHAR (30),
@Nombre VARCHAR (30),
@Descripcion VARCHAR (30),
@IdCategoria INT,
@Estado BIT,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN
		SET @Resultado = 1
		IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo AND IdProducto != @IdProducto)
		BEGIN
			UPDATE producto SET
			Codigo = @Codigo,
			Nombre = @Nombre,
			Descripcion = @Descripcion,
			IdCategoria = @IdCategoria,
			Estado = @Estado
			WHERE IdProducto = @IdProducto
		END
		ELSE
			BEGIN
				SET @Resultado = 0
				SET @Mensaje = 'Existe un producto con el mismo codigo'
			END
	END
GO

CREATE PROCEDURE SP_EliminarProducto (
@IdProducto INT,
@Respuesta BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN 
		SET @Respuesta = 1
		DECLARE @PasoReglas BIT = 1
		IF EXISTS (SELECT * FROM detalle_compra 
				  JOIN producto ON detalle_compra.IdProducto = producto.IdProducto
				  WHERE producto.IdProducto = @IdProducto)
			BEGIN
				SET @PasoReglas = 0
				SET @Respuesta = 0
				SET @Mensaje = 'No se puede eliminar porque esta en la lista de productos comprados'
			END 

		IF EXISTS (SELECT * FROM detalle_venta
				  JOIN producto ON detalle_venta.IdProducto = producto.IdProducto
				  WHERE producto.IdProducto = @IdProducto)
			BEGIN
				SET @PasoReglas = 0
				SET @Respuesta = 0
				SET @Mensaje = 'No se puede eliminar porque esta en la lista de productos vendidos'
			END 
		IF (@PasoReglas = 1)
		BEGIN
			DELETE FROM producto WHERE IdProducto = @IdProducto
			SET @Respuesta = 1
		END
	END 
GO

/* CLIENTES */

CREATE PROCEDURE SP_RegistrarCliente (
@Documento VARCHAR (50),
@NombreCompleto VARCHAR (50),
@Correo VARCHAR (50),
@Telefono VARCHAR (50),
@Estado BIT,
@Resultado INT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN 
		SET @Resultado = 0
		DECLARE @IDPERSONA INT
		IF NOT EXISTS (SELECT * FROM cliente WHERE Documento = @Documento)
		BEGIN 
			INSERT INTO cliente (Documento, NombreCompleto, Correo, Telefono, Estado)
				   VALUES (@Documento, @NombreCompleto, @Correo, @Telefono, @Estado)
			SET @Resultado = SCOPE_IDENTITY()
		END 
		ELSE 
			SET @Mensaje = 'Ya existe el cliente con ese DNI'
	END
GO

CREATE PROCEDURE SP_ModificarCliente (
@IdCliente INT,
@Documento VARCHAR (50),
@NombreCompleto VARCHAR (50),
@Correo VARCHAR (50),
@Telefono VARCHAR (50),
@Estado BIT,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS 
	SET @Resultado = 1
	DECLARE @IDPERSONA INT 
	IF NOT EXISTS (SELECT * FROM cliente WHERE Documento = @Documento AND IdCliente != @IdCliente)
	BEGIN 
		UPDATE cliente SET
		Documento = @Documento,
		NombreCompleto = @NombreCompleto,
		Correo = @Correo,
		Telefono = @Telefono,
		Estado = @Estado
		WHERE @IdCliente = IdCliente
	END
	ELSE
	BEGIN
		SET @Resultado = 0
		SET @Mensaje = 'El numero de documento ya esta registradoooooooooooooooooooo'
	END
GO

/* PROVEEDORES */

CREATE PROCEDURE SP_RegistrarProveedor(
@Documento VARCHAR (50),
@RazonSocial VARCHAR (50),
@Correo VARCHAR (50),
@Telefono VARCHAR (50),
@Estado BIT,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (50) OUTPUT
) 
AS
	BEGIN
		SET @Resultado = 0
		DECLARE @IDPERSONA INT 
		IF NOT EXISTS (SELECT * FROM proveedor WHERE Documento = @Documento)
		BEGIN 
			INSERT INTO proveedor (Documento, RazonSocial, Correo, Telefono, Estado)
				   VALUES (@Documento, @RazonSocial, @Correo, @Telefono, @Estado)
			SET @Resultado = SCOPE_IDENTITY()
		END 
		ELSE 
			SET @Mensaje = 'El proveedor ya existe' 
	END
GO

CREATE PROCEDURE SP_ModificarProveedor(
@IdProveedor INT, 
@Documento VARCHAR (50),
@RazonSocial VARCHAR (50),
@Correo VARCHAR (50),
@Telefono VARCHAR (50),
@Estado BIT ,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (50) OUTPUT
)
AS
	BEGIN
		SET @Resultado = 1
		DECLARE @IDPERSONA INT
		IF NOT EXISTS (SELECT * FROM proveedor WHERE Documento = @Documento AND IdProveedor != @IdProveedor)
		BEGIN
			UPDATE proveedor SET 
			Documento = @Documento,
			RazonSocial = @RazonSocial,
			Correo = @Correo,
			Telefono = @Telefono,
			Estado = @Estado
			WHERE IdProveedor = @IdProveedor
		END
		ELSE 
			BEGIN
				SET @Mensaje = 'El proveedor ya existe' 
				SET @Resultado = 0
			END
	END
GO

CREATE PROCEDURE SP_EliminarProveedor (
@IdProveedor INT,
@Mensaje VARCHAR (500) OUTPUT,
@Resultado BIT OUTPUT
)
AS
	BEGIN 
		SET @Resultado = 1
		IF NOT EXISTS (SELECT * FROM proveedor
					  JOIN compra ON proveedor.IdProveedor = compra.IdProveedor
					  WHERE proveedor.IdProveedor = @IdProveedor)
		BEGIN 
			DELETE FROM proveedor WHERE IdProveedor = @IdProveedor
		END
		ELSE 
			BEGIN
				SET @Resultado = 0
				SET @Mensaje = ' No se puede eliminar el proveedor porque se encuentra asociado a una compra'
			END 
	END
GO

/* PROCESOS PARA REGISTRAR UNA COMPRA */

CREATE TYPE EDetalle_Compra 
AS
TABLE (
	IdProducto INT NULL,
	PrecioCompra DECIMAL (18,2) NULL,
	PrecioVenta DECIMAL (18,2) NULL,
	Cantidad INT NULL,
	MontoTotal DECIMAL (18,2) NULL
)
GO

CREATE PROCEDURE SP_RegistrarCompra (
@IdUsuario INT,
@IdProveedor INT,
@TipoDocumento VARCHAR (500),
@NumeroDocumento VARCHAR (500),
@NombreCompleto VARCHAR (500),
@MontoTotal DECIMAL (18,2),
@Detalle_Compra [EDetalle_Compra] READONLY,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN
		BEGIN TRY
			DECLARE @IdCompra INT = 0
			SET @Resultado = 1
			SET @Mensaje = ''

			BEGIN TRANSACTION registro
				INSERT INTO compra (IdUsuario, IdProveedor, TipoDocumento, NumeroDocumento, NombreCompleto, MontoTotal)
				   	         VALUES(@IdUsuario, @IdProveedor, @TipoDocumento, @NumeroDocumento,@NombreCompleto, @MontoTotal)
				SET @IdCompra = SCOPE_IDENTITY()
				
				INSERT INTO detalle_compra (IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal)
				
				SELECT @IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal FROM @Detalle_Compra
				
				UPDATE producto SET producto.Stock = dc.Cantidad + producto.Stock,
								    producto.PrecioCompra = dc.PrecioCompra,
									producto.PrecioVenta = dc.PrecioVenta
									FROM producto
									JOIN @Detalle_Compra dc ON dc.IdProducto = producto.IdProducto

			COMMIT TRANSACTION registro


		END TRY
		BEGIN CATCH
			SET @Resultado = 0
			SET @Mensaje = 'ERRORRRRR\n\n' + ERROR_MESSAGE()
			ROLLBACK TRANSACTION registro 
		END CATCH
	END
GO

/* PROCESOS PARA REGISTRAR VENTAS */


CREATE TYPE EDetalle_Venta AS TABLE(
IdProducto INT NULL,
PrecioVenta DECIMAL (18,2) NULL,
Cantidad INT NULL,
SubTotal DECIMAL (18,2) NULL
)
GO

CREATE PROCEDURE SP_RegistrarVenta (
@IdUsuario INT,
@TipoDocumento VARCHAR (500),
@NumeroDocuemento VARCHAR (500),
@DocumentoCliente VARCHAR (500),
@NombreCliente VARCHAR (500),
@MontoPago DECIMAL (18,2),
@MontoCambio DECIMAL (18,2),
@MontoTotal DECIMAL (18,2),
@DetalleVenta [EDetalle_Venta] READONLY,
@Resultado BIT OUTPUT,
@Mensaje VARCHAR (500) OUTPUT
)
AS
	BEGIN
		BEGIN TRY 
			DECLARE @IdVenta INT = 0
			SET @Resultado = 1
			SET @Mensaje = ''

			BEGIN TRANSACTION registro 
				
				INSERT INTO venta (IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal)
				VALUES (@IdUsuario, @TipoDocumento, @NumeroDocuemento, @DocumentoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal)

				SET @IdVenta = SCOPE_IDENTITY()

				INSERT INTO detalle_venta (IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal)
				SELECT @IdVenta, IdProducto, PrecioVenta, Cantidad, SubTotal FROM @DetalleVenta

			COMMIT TRANSACTION registro
		END TRY
		BEGIN CATCH
			SET @Resultado = 0
			SET @Mensaje = ERROR_MESSAGE()
			ROLLBACK TRANSACTION registro 
		END CATCH
	END
GO

/* REPORTES  */

CREATE PROCEDURE SP_ReporteCompra (
@FechaInicio VARCHAR (10),
@FechaFin VARCHAR (10),
@IdProveedor INT 
)
AS
	BEGIN 
		SET DATEFORMAT dmy

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
		WHERE CONVERT(DATE, compra.FechaRegistro) BETWEEN @FechaInicio AND @FechaFin 
			  AND proveedor.IdProveedor = IIF (@IdProveedor = 0, proveedor.IdProveedor, @IdProveedor)
	END
GO

CREATE PROCEDURE SP_ReporteVentas (
@FechaInicio VARCHAR (10),
@FechaFin VARCHAR (10)
)
AS 
	BEGIN 
		SET DATEFORMAT dmy
		
		SELECT CONVERT(CHAR(10), venta.FechaRegistro, 103)[FechaRegistro], venta.TipoDocumento, venta.NumeroDocumento, venta.MontoTotal, venta.DocumentoCliente, venta.NombreCliente,
		usuario.NombreCompleto[UsuarioRegistro], 
		producto.Codigo[CodigoProducto], producto.Nombre[NombreProducto],
		categoria.Descripcion[Categoria], detalle_venta.PrecioVenta, detalle_venta.Cantidad, detalle_venta.SubTotal
		
		FROM venta
		JOIN usuario ON usuario.IdUsuario = venta.IdUsuario
		JOIN detalle_venta ON detalle_venta.IdVenta = venta.IdVenta
		JOIN producto ON producto.IdProducto = detalle_venta.IdVenta
		JOIN categoria ON categoria.IdCategoria = producto.IdCategoria
		WHERE CONVERT(DATE, venta.FechaRegistro) BETWEEN @FechaInicio AND @FechaFin
	END
GO









































