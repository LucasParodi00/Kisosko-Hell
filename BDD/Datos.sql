


/* NEGOCIO */
INSERT INTO negocio (IdNegocio, Nombre, RUC, Direccion) VALUES (01, 'LIBRERIA CORRIENTES', '000000', 'Av. Nose donde 0200')
GO

/* PERMISOS */
INSERT INTO permiso (IdRol, Nombre) VALUES 

(1, 'MenuVentas'),
(1, 'MenuClientes'),

(2, 'MenuVentas'),
(2, 'MenuClientes'),
(2, 'MenuCompras'),
(2, 'MenuProveedores'),
(2, 'MenuMantenedor'),

(3, 'MenuReportes'),
(3, 'MenuProveedores'),
(3, 'MenuUsuarios'),
(3, 'MenuAcercaDe')
GO

/* ROLES */
INSERT INTO rol (Descripcion) VALUES
('Empleado'),
('Administrador'),
('Super Administrador');
GO

/* USUARIOS */
INSERT INTO usuario (Documento, NombreCompleto, Correo, Clave, IdRol, Estado) 
VALUES 
('14278042', 'EMPLEADO', 'empleado@gmail.com', '123',1,1), 
('14278055', 'ADMINISTRADOR', 'administrador@gmail.com', '123',2,1),
('40876821', 'SUPER ADMIN', 'superAdmin@gmail.com', '123', 3, 1),
('54111445', 'EMPLEADO 2', 'empleado2@gmail.com', '123', 1, 0)
GO

/* DATOS PROVEEDOR */
INSERT INTO proveedor (Documento, RazonSocial, Correo, Telefono, Estado) 
VALUES 
('45113456', 'S.E Libreria', 'seLibreria@correo.com', '3794-551414', 1),
('54451445', 'La Cañita SA', 'laCañita@correo.com', '3794-4554411', 1),
('44174774', 'Libreria Curuzu', 'curuzu@correo.com', '3794-744774', 1),
('45113456', 'Libreria VEO VEO', 'veoveolibreria@correo.com', '3794-744411', 1),
('45113456', 'Contexto Libreria', 'contexto@correo.com', '3794-777444', 1),
('45113456', 'De la Paz', 'delapaz@correo.com', '3794-212425', 1)
GO

/* CLIENTES */
INSERT INTO cliente (Documento, NombreCompleto, Correo, Telefono, Estado)
VALUES
('40844788', 'Sebastian Marcelo Ponce', '@correo.com', '3794-788454', 1),
('65411114', 'Micaela Gian Nuñez', '@correo.com', '3794-225464', 1),
('65552222', 'Magali Nicole Acebedo', '@correo.com', '3794-123456', 1),
('32654151', 'Javier Marcos Medina', '@correo.com', '3794-744414', 1),
('54561121', 'Camila Karen Humberto', '@correo.com', '3794-999655', 1),
('12451142', 'Bautista Patricio Escobar', '@correo.com', '3794-422134', 1)
GO

/* CATEGORIA */
INSERT INTO categoria (Descripcion, Estado)
VALUES 
('Libros', 1),
('Mangas', 1),
('Novelas', 1),
('Historietas', 1),
('Revistas', 1)
GO

/* PRODUCTOS */
INSERT INTO producto (IdCategoria, Nombre, Codigo, Descripcion, Stock, PrecioCompra, PrecioVenta, Estado)
VALUES 
(1, 'Harry Potter', 'L-001', 'Edicion de Bolsillo', 1, 4200, 7210, 1),
(1, 'El Señor de los Anillos', 'L-033', 'Tomo Grande', 10, 1000, 1500, 1), 
(2, 'One Pice', 'M-112', 'Tomo Grande', 14, 11500, 13700, 1),
(2, 'Naruto', 'N-471', 'Tomo Grande', 3, 17000, 18900, 1),
(2, 'Dragon Ball', 'N-771', 'Tomo Grande', 3, 20000, 21900, 1),
(2, 'Demon Slayer', 'N-133', 'Edicion de Bolsillo', 3, 27800, 35400, 1),
(3, 'Don Quijote de la Mancha', 'N-421', 'Tomo Grande', 3, 1500, 1700, 1),
(3, 'Orgullo y Perjuicio', 'N-677', 'Tomo Grande', 4, 7500, 8200, 1),
(3, 'Guerra y Paz', 'N-655', 'Edicion de Bolsillo', 3, 760, 1100, 1),
(5, 'Nature', 'R-101', 'Edicion Citaciones', 3, 100, 110, 1),
(5, 'Jam Chem Soc', 'R-001', 'Edicion Cool', 1, 100, 110, 1),
(5, 'Phys Rev Lett Issn', 'R-001', 'Miami Beatch', 9, 100, 110, 1)
GO




















