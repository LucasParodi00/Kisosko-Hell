
/*DROP DATABASE proyecto_tallerII*/

/* NEGOCIO */
INSERT INTO negocio (IdNegocio, Nombre, RUC, Direccion) VALUES (01, 'LIBRERIA CORRIENTES', '000000', 'Av. Nose donde 0200')
GO

/* ROLES */
INSERT INTO rol (Descripcion) VALUES
('Empleado'),
('Administrador'),
('Super Administrador');
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
('12451142', 'Bautista Patricio Escobar', '@correo.com', '3794-422134', 1),
('42123141', 'Martina Marta Echeveriia', '@correo.com', '3794-774534', 1),
('78523641', 'Luisa Fernández', 'luisa@gmail.com', '3365-125879', 1),
('96321478', 'Andrés Soto', 'asoto@hotmail.com', '3991-528714', 1),
('45871236', 'María Rodríguez', 'mrodriguez@yahoo.com', '3784-625879', 1),
('12458963', 'Pedro Gómez', 'pgomez@gmail.com', '3675-215487', 1),
('63254187', 'Ana López', 'alopez@hotmail.com', '3356-987412', 1),
('78451236', 'Carlos Ramírez', 'cramirez@gmail.com', '3894-365214', 1),
('32547896', 'Laura Torres', 'ltorres@yahoo.com', '3975-214578', 1),
('98754123', 'Javier Mendoza', 'jmendoza@hotmail.com', '3568-147896', 1),
('24569871', 'Mariana Silva', 'msilva@gmail.com', '3875-369845', 1),
('74589632', 'Ricardo Morales', 'rmorales@hotmail.com', '3496-587412', 1),
('36897541', 'Fernanda Herrera', 'fherrera@yahoo.com', '3258-147896', 1),
('58741236', 'Roberto Castro', 'rcastro@gmail.com', '3158-147896', 1),
('96321458', 'Sara Guzmán', 'sguzman@hotmail.com', '3865-147258', 1),
('14725836', 'Gabriel Paredes', 'gparedes@yahoo.com', '3297-258741', 1),
('36587412', 'Camila Ríos', 'crios@gmail.com', '3965-123587', 1),
('63258741', 'Diego Núñez', 'dnunez@hotmail.com', '3885-321654', 1),
('21478536', 'Valentina Ortega', 'vortega@gmail.com', '3448-456987', 1),
('78563214', 'Eduardo Vargas', 'evargas@yahoo.com', '3359-784521', 1),
('41258736', 'Isabella Romero', 'iromero@hotmail.com', '3857-965874', 1),
('25874136', 'Mateo Rojas', 'mrojas@gmail.com', '3952-456321', 1),
('69874512', 'Carolina Méndez', 'cmendez@yahoo.com', '3294-365874', 1),
('32458716', 'Daniel Pineda', 'dpineda@gmail.com', '3869-985412', 1),
('47896521', 'Alejandra Morales', 'amorales@hotmail.com', '3796-985674', 1),
('98654721', 'Patricia Castillo', 'pcastillo@yahoo.com', '3957-125487', 1),
('25874196', 'Jorge Salazar', 'jsalazar@gmail.com', '3668-965874', 1),
('36521478', 'Miguel Sánchez', 'msanchez@hotmail.com', '3294-365874', 1),
('74196385', 'Natalia Delgado', 'ndelgado@gmail.com', '3963-365874', 1),
('21548736', 'Renato Rivas', 'rrivas@yahoo.com', '3896-589654', 1),
('96587412', 'Daniela Vidal', 'dvidal@gmail.com', '3662-587412', 1),
('87412536', 'Lucas Cáceres', 'lcaceres@hotmail.com', '3869-965874', 1),
('32478951', 'Antonella Aguirre', 'aaguirre@yahoo.com', '3589-965874', 1),
('74589631', 'Roberta Gómez', 'rgomez@gmail.com', '3689-965874', 1),
('85462137', 'Maximiliano Guzmán', 'mguzman@hotmail.com', '3458-965874', 1),
('36587421', 'Catalina Mendoza', 'cmendoza@yahoo.com', '3862-365874', 1),
('98563247', 'Sergio Morales', 'smorales@gmail.com', '3869-589654', 1),
('98741523', 'Valeria Vargas', 'vvargas@hotmail.com', '3669-365874', 1),
('32547869', 'Hernán Silva', 'hsilva@yahoo.com', '3469-589654', 1),
('78452136', 'Florencia Castro', 'fcastro@gmail.com', '3758-365874', 1),
('32587416', 'Sebastián Paredes', 'sparedes@hotmail.com', '3896-985674', 1),
('36587429', 'Marcela Ríos', 'mrios@gmail.com', '3589-589654', 1),
('98741236', 'Diego Núñez', 'dnunez@hotmail.com', '3879-965874', 1),
('47896523', 'Carolina Ortega', 'cortega@gmail.com', '3958-589654', 1),
('98745632', 'Felipe Vargas', 'fvargas@yahoo.com', '3859-589654', 1),
('36521478', 'Isabella Romero', 'iromero@hotmail.com', '3668-589654', 1),
('25478963', 'Lucía Rojas', 'lrojas@gmail.com', '3589-589654', 1),
('98654712', 'Lorenzo Méndez', 'lmendez@yahoo.com', '3986-365874', 1),
('74589623', 'Emilia Pineda', 'epineda@gmail.com', '3868-965874', 1),
('36587412', 'Ignacio Morales', 'imorales@hotmail.com', '3896-589654', 1),
('78965423', 'Amanda Castillo', 'acastillo@yahoo.com', '3769-589654', 1),
('45874563', 'Matías Salazar', 'msalazar@gmail.com', '3679-589654', 1),
('78234567', 'María Rodríguez', 'mrodriguez@gmail.com', '3568-124567', 1),
('89564231', 'Luisa Fernández', 'lfernandez@gmail.com', '7823-456789', 1),
('26785942', 'Juan Pérez', 'jperez@gmail.com', '9842-345678', 1),
('13578964', 'Ana Gómez', 'agomez@gmail.com', '4356-876543', 1),
('42365987', 'Pedro Ramírez', 'pramirez@gmail.com', '6879-234567', 1),
('45678592', 'Carolina Torres', 'ctorres@gmail.com', '9234-567890', 1),
('98764321', 'Andrés Martínez', 'amartinez@gmail.com', '6789-012345', 1),
('56789234', 'Laura Sánchez', 'lsanchez@gmail.com', '0123-456789', 1),
('45673451', 'José Romero', 'jromero@gmail.com', '5678-901234', 1),
('12345678', 'Marcela Ruiz', 'mruiz@gmail.com', '9012-345678', 1),
('87654321', 'Fernando Morales', 'fmorales@gmail.com', '2345-678901', 1),
('23456789', 'Gabriela Ortega', 'gortega@gmail.com', '6789-012345', 1),
('78901234', 'Pedro López', 'plopez@gmail.com', '0123-456789', 1),
('34567890', 'Camila Castro', 'ccastro@gmail.com', '4567-890123', 1),
('90123456', 'Roberto González', 'rgonzalez@gmail.com', '8901-234567', 1),
('56789012', 'Carolina Silva', 'csilva@gmail.com', '2345-678901', 1),
('12348965', 'Pablo Mendoza', 'pmendoza@gmail.com', '6789-012345', 1),
('98761234', 'Valentina Rojas', 'vrojas@gmail.com', '0123-456789', 1),
('54326789', 'Andrea López', 'alopez@gmail.com', '4567-890123', 1),
('87651234', 'Juan Torres', 'jtorres@gmail.com', '8901-234567', 1),
('43219876', 'Sandra Medina', 'smedina@gmail.com', '2345-678901', 1),
('98762341', 'Federico Morales', 'fmorales@gmail.com', '6789-012345', 1),
('45671234', 'María Fernández', 'mfernandez@gmail.com', '0123-456789', 1),
('23456178', 'Javier González', 'jgonzalez@gmail.com', '4567-890123', 1),
('89012345', 'Laura Torres', 'ltorres@gmail.com', '8901-234567', 1),
('12345671', 'Mariana Rojas', 'mrojas@gmail.com', '2345-678901', 1),
('56781234', 'Gabriel Sánchez', 'gsanchez@gmail.com', '6789-012345', 1),
('98765432', 'Valeria Ortega', 'vortega@gmail.com', '0123-456789', 1),
('34567812', 'Roberto Mendoza', 'rmendoza@gmail.com', '4567-890123', 1),
('90128765', 'Carolina Castro', 'ccastro@gmail.com', '8901-234567', 1),
('43216587', 'Fernanda Ruiz', 'fruiz@gmail.com', '2345-678901', 1),
('98765412', 'Santiago Morales', 'smorales@gmail.com', '6789-012345', 1),
('45672345', 'María González', 'mgonzalez@gmail.com', '0123-456789', 1),
('23456719', 'Javier Rojas', 'jrojas@gmail.com', '4567-890123', 1),
('89012346', 'Laura Sánchez', 'lsanchez@gmail.com', '8901-234567', 1),
('12345672', 'Mariana Ortega', 'mortega@gmail.com', '2345-678901', 1),
('56781235', 'Gabriel Mendoza', 'gmendoza@gmail.com', '6789-012345', 1),
('98765431', 'Valeria Castro', 'vcastro@gmail.com', '0123-456789', 1),
('34567821', 'Roberto Ruiz', 'rruiz@gmail.com', '4567-890123', 1),
('90128756', 'Carolina Morales', 'cmorales@gmail.com', '8901-234567', 1),
('43216578', 'Fernanda González', 'fgonzalez@gmail.com', '2345-678901', 1),
('98765421', 'Santiago Rojas', 'srojas@gmail.com', '6789-012345', 1),
('45672354', 'María Sánchez', 'msanchez@gmail.com', '0123-456789', 1),
('23456791', 'Javier Ortega', 'jortega@gmail.com', '4567-890123', 1),
('89012347', 'Laura Mendoza', 'lmendoza@gmail.com', '8901-234567', 1),
('12345673', 'Mariana Castro', 'mcastro@gmail.com', '2345-678901', 1),
('56781236', 'Gabriel Ruiz', 'gruiz@gmail.com', '6789-012345', 1),
('98765437', 'Valeria Morales', 'vmorales@gmail.com', '0123-456789', 1),
('34567823', 'Roberto González', 'rgonzalez@gmail.com', '4567-890123', 1),
('90128764', 'Carolina Sánchez', 'csanchez@gmail.com', '8901-234567', 1),
('43216576', 'Fernanda Ortega', 'fortega@gmail.com', '2345-678901', 1)
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
(5, 'Phys Rev Lett Issn', 'R-001', 'Miami Beatch', 9, 100, 110, 1),

/*GENERADOS*/
/*LIBROS*/
(1, 'Harry Potter y la Piedra Filosofal', 'HP-001', 'El primer libro de la famosa serie de Harry Potter', 10, 1500, 2500, 1),
(1, 'Cien años de soledad', 'CS-002', 'Una novela icónica escrita por Gabriel García Márquez', 5, 1200, 2000, 1),
(1, 'El Gran Gatsby', 'GG-003', 'Una novela clásica de F. Scott Fitzgerald', 3, 1000, 1800, 1),
(1, '1984', 'N-004', 'Una distopía escrita por George Orwell', 8, 800, 1500, 1),
(1, 'Matar a un ruiseñor', 'MR-005', 'Una novela de Harper Lee', 6, 1100, 1900, 1),
(1, 'Orgullo y prejuicio', 'OP-006', 'Una obra de Jane Austen', 4, 900, 1700, 1),
(1, 'Ulises', 'U-007', 'Una novela escrita por James Joyce', 2, 1300, 2100, 1),
(1, 'Don Quijote de la Mancha', 'DQ-008', 'La famosa obra de Miguel de Cervantes Saavedra', 7, 1400, 2300, 1),
(1, 'Moby Dick', 'MD-009', 'Una novela épica de Herman Melville', 9, 1600, 2400, 1),
(1, 'El Gran Libro de los Sueños', 'GLS-010', 'Un libro sobre interpretación de sueños', 12, 800, 1500, 1),
(1, 'El Código Da Vinci', 'CDV-011', 'Un thriller de Dan Brown', 11, 1300, 2100, 1),
(1, 'El Principito', 'EP-012', 'Una fábula escrita por Antoine de Saint-Exupéry', 15, 1000, 1800, 1),
(1, 'Crimen y castigo', 'CC-013', 'Una novela de Fyodor Dostoyevsky', 7, 1200, 2000, 1),
(1, 'Las aventuras de Tom Sawyer', 'TS-014', 'Una novela de Mark Twain', 9, 900, 1700, 1),
(1, 'El retrato de Dorian Gray', 'RDG-015', 'Una obra de Oscar Wilde', 3, 1100, 1900, 1),
(1, 'Los pilares de la Tierra', 'LPT-016', 'Una novela de Ken Follett', 6, 1400, 2300, 1),
(1, 'Viaje al centro de la Tierra', 'VCT-017', 'Una novela de Julio Verne', 5, 1500, 2500, 1),
(1, 'La Odisea', 'LO-018', 'Un poema épico de Homero', 10, 1000, 1800, 1),
(1, 'El Extranjero', 'EE-019', 'Una novela de Albert Camus', 4, 800, 1500, 1),
(1, 'El Hobbit', 'EH-020', 'Una novela de J.R.R. Tolkien', 6, 1200, 2000, 1),
(1, 'El Alquimista', 'EA-021', 'Una novela de Paulo Coelho', 8, 1100, 1900, 1),
(1, 'Drácula', 'D-022', 'Una novela de Bram Stoker', 3, 1300, 2100, 1),
(1, 'Cuentos de Edgar Allan Poe', 'CEAP-023', 'Una colección de cuentos del famoso autor', 7, 900, 1700, 1),
(1, 'Las uvas de la ira', 'LUI-024', 'Una novela de John Steinbeck', 9, 1500, 2500, 1),
(1, 'El guardián entre el centeno', 'GEC-025', 'Una novela de J.D. Salinger', 6, 1000, 1800, 1),
(1, 'Anna Karenina', 'AK-026', 'Una novela de Leo Tolstoy', 5, 1200, 2000, 1),
(1, 'Crónica de una muerte anunciada', 'CMA-027', 'Una novela de Gabriel García Márquez', 8, 1100, 1900, 1),
(1, 'El viejo y el mar', 'VYM-028', 'Una novela de Ernest Hemingway', 4, 1000, 1800, 1),
(1, 'Frankenstein', 'F-029', 'Una novela de Mary Shelley', 3, 1300, 2100, 1),
(1, 'El nombre de la rosa', 'NR-030', 'Una novela de Umberto Eco', 6, 1200, 2000, 1),

/*MANGAS*/

(2, 'One Punch Man', 'M-678', 'Manga de ONE y Yusuke Murata', 10, 14.99, 21.99, 1),
(2, 'Hunter x Hunter', 'M-912', 'Manga de Yoshihiro Togashi', 8, 12.99, 19.99, 1),
(2, 'Demon Slayer', 'M-345', 'Manga de Koyoharu Gotouge', 15, 11.99, 18.99, 1),
(2, 'Haikyu!!', 'M-567', 'Manga de Haruichi Furudate', 12, 10.99, 17.99, 1),
(2, 'My Hero Academia: Vigilantes', 'M-890', 'Manga de Hideyuki Furuhashi y Betten Court', 7, 9.99, 16.99, 1),
(2, 'Sailor Moon', 'M-123', 'Manga de Naoko Takeuchi', 10, 13.99, 20.99, 1),
(2, 'Berserk', 'M-234', 'Manga de Kentaro Miura', 20, 15.99, 22.99, 1),
(2, 'Fairy Tail', 'M-456', 'Manga de Hiro Mashima', 5, 12.99, 19.99, 1),
(2, 'Attack on Titan: Before the Fall', 'M-789', 'Manga de Ryo Suzukaze y Satoshi Shiki', 8, 11.99, 18.99, 1),
(2, 'Nana', 'M-901', 'Manga de Ai Yazawa', 15, 14.99, 21.99, 1),
(2, 'Attack on Titan: No Regrets', 'M-901', 'Manga de Gun Snark y Hikaru Suruga', 18, 13.99, 20.99, 1),
(2, 'Tokyo Ghoul', 'M-234', 'Manga de Sui Ishida', 10, 11.99, 18.99, 1),
(2, 'Fullmetal Alchemist', 'M-567', 'Manga de Hiromu Arakawa', 5, 9.99, 16.99, 1),

/* NOVELAS */
(3, 'It', 'N-123', 'Novela de Stephen King', 10, 12.99, 19.99, 1),
(3, 'The Shining', 'N-456', 'Novela de Stephen King', 15, 14.99, 21.99, 1),
(3, 'Pet Sematary', 'N-789', 'Novela de Stephen King', 8, 11.99, 17.99, 1),
(3, 'Misery', 'N-234', 'Novela de Stephen King', 20, 13.99, 20.99, 1),
(3, 'Carrie', 'N-345', 'Novela de Stephen King', 12, 10.99, 16.99, 1),
(3, 'The Stand', 'N-567', 'Novela de Stephen King', 7, 9.99, 15.99, 1),
(3, 'Cujo', 'N-901', 'Novela de Stephen King', 18, 13.99, 20.99, 1),
(3, 'The Dark Tower', 'N-234', 'Serie de novelas de Stephen King', 10, 11.99, 18.99, 1),
(3, 'Salem s Lot', 'N-567', 'Novela de Stephen King', 5, 9.99, 15.99, 1),
(3, 'The Green Mile', 'N-890', 'Novela de Stephen King', 15, 12.99, 19.99, 1),
(3, 'The Pillars of the Earth', 'N-123', 'Novela de Ken Follett', 10, 12.99, 19.99, 1),
(3, 'World Without End', 'N-456', 'Novela de Ken Follett', 15, 14.99, 21.99, 1),
(3, 'Fall of Giants', 'N-789', 'Novela de Ken Follett', 8, 11.99, 17.99, 1),
(3, 'Winter of the World', 'N-234', 'Novela de Ken Follett', 20, 13.99, 20.99, 1),
(3, 'Edge of Eternity', 'N-345', 'Novela de Ken Follett', 12, 10.99, 16.99, 1),
(3, 'The Eye of the Needle', 'N-567', 'Novela de Ken Follett', 7, 9.99, 15.99, 1),
(3, 'A Dangerous Fortune', 'N-901', 'Novela de Ken Follett', 18, 13.99, 20.99, 1),
(3, 'The Key to Rebecca', 'N-234', 'Novela de Ken Follett', 10, 11.99, 18.99, 1),
(3, 'The Man from St. Petersburg', 'N-567', 'Novela de Ken Follett', 5, 9.99, 15.99, 1),
(3, 'A Column of Fire', 'N-890', 'Novela de Ken Follett', 15, 12.99, 19.99, 1)
GO


















