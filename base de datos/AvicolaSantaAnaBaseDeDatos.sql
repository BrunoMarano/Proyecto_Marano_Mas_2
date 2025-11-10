CREATE DATABASE AvicolaSantaAna1;

USE AvicolaSantaAna1;


-- Tabla Metodo_Pago
CREATE TABLE Metodo_Pago
(
  Id_metodo_pago INT IDENTITY(1,1) NOT NULL,
  Tipo INT NOT NULL,
  CONSTRAINT PK_Metodo_pago PRIMARY KEY (Id_metodo_pago)
);

-- Tabla Rol
CREATE TABLE Rol
(
  Id_rol INT IDENTITY(1,1) NOT NULL,
  Rol VARCHAR(150) NOT NULL,
  CONSTRAINT PK_Rol PRIMARY KEY (Id_rol)
);

-- Tabla Provincia
CREATE TABLE Provincia
(
  id_provincia INT IDENTITY(1,1) NOT NULL,
  provincia VARCHAR(200) NOT NULL,
  CONSTRAINT PK_Provincia PRIMARY KEY (id_provincia)
);

-- Tabla Categoria
CREATE TABLE Categoria
(
  id_categoria INT IDENTITY(1,1) NOT NULL,
  descripcion VARCHAR(200) NOT NULL,
  activo BIT NOT NULL,
  CONSTRAINT PK_Categoria PRIMARY KEY (id_categoria)
);

-- Tabla Usuario
CREATE TABLE Usuario
(
  Dni INT NOT NULL,
  Nombre VARCHAR(200) NOT NULL,
  Apellido VARCHAR(100) NOT NULL,
  Id_usuario INT IDENTITY(1,1) NOT NULL,
  Correo VARCHAR(200) NOT NULL,
  Telefono VARCHAR(20) NOT NULL,
  Sexo VARCHAR(20) NOT NULL,
  Fecha_Nacimiento DATE NOT NULL,
  contraseña VARCHAR(600) NOT NULL,
  baja BIT NOT NULL,
  Id_rol INT NOT NULL,
  CONSTRAINT PK_Usuario PRIMARY KEY (Id_usuario),
  CONSTRAINT FK_Usuario_Rol FOREIGN KEY (Id_rol) REFERENCES Rol(Id_rol),
  UNIQUE (Dni)
);

-- Tabla Producto
CREATE TABLE Producto
(
  Id_producto INT IDENTITY(1,1) NOT NULL,
  descripcion VARCHAR(200) NOT NULL,
  precio FLOAT NOT NULL,
  stock INT NOT NULL,
  stock_minimo INT NOT NULL,
  eliminado BIT NOT NULL,
  id_categoria INT NOT NULL,
  CONSTRAINT PK_Producto PRIMARY KEY (Id_producto),
  CONSTRAINT FK_Producto_Categoria FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria)
);

-- Tabla Ciudad
CREATE TABLE Ciudad
(
  id_ciudad INT IDENTITY(1,1) NOT NULL,
  ciudad VARCHAR(200) NOT NULL,
  id_provincia INT NOT NULL,
  CONSTRAINT PK_Ciudad PRIMARY KEY (id_ciudad),
  CONSTRAINT FK_Ciudad_Provincia FOREIGN KEY (id_provincia) REFERENCES Provincia(id_provincia)
);

-- Tabla Cliente
CREATE TABLE Cliente
(
  nombre VARCHAR(100) NOT NULL,
  apellido VARCHAR(100) NOT NULL,
  Cuit BIGINT NOT NULL,
  Telefono VARCHAR(20) NOT NULL,
  Direccion VARCHAR(200) NOT NULL,
  Id_cliente INT IDENTITY(1,1) NOT NULL,
  id_ciudad INT NOT NULL,
  CONSTRAINT PK_Cliente PRIMARY KEY (Id_cliente),
  CONSTRAINT FK_Cliente_Ciudad FOREIGN KEY (id_ciudad) REFERENCES Ciudad(id_ciudad),
  UNIQUE (Cuit)
);


-- Tabla Proveedor
CREATE TABLE Proveedor
(
  Codigo_proveedor INT IDENTITY(1,1) NOT NULL,
  Nombre VARCHAR(200) NOT NULL,
  Direccion VARCHAR(200) NOT NULL,
  telefono VARCHAR(20) NOT NULL,
  cuit BIGINT NOT NULL,
  id_ciudad INT NOT NULL,
  CONSTRAINT PK_Proveedor PRIMARY KEY (Codigo_proveedor),
  CONSTRAINT FK_Proveedor_Ciudad FOREIGN KEY (id_ciudad) REFERENCES Ciudad(id_ciudad),
  UNIQUE (cuit)
);

-- Tabla Producto_Proveedor
CREATE TABLE Producto_Proveedor
(
  precio_costo FLOAT NOT NULL,
  Id_producto INT NOT NULL,
  Codigo_proveedor INT NOT NULL,
  CONSTRAINT PK_Producto_proveedor PRIMARY KEY (Id_producto, Codigo_proveedor),
  CONSTRAINT FK_Producto_proveedor_Producto FOREIGN KEY (Id_producto) REFERENCES Producto(Id_producto),
  CONSTRAINT FK_Producto_proveedor_Proveedor FOREIGN KEY (Codigo_proveedor) REFERENCES Proveedor(Codigo_proveedor)
);

-- Tabla Venta
CREATE TABLE Venta
(
  Id_venta INT IDENTITY(1,1) NOT NULL,
  fecha_venta DATE NOT NULL,
  total_venta FLOAT NOT NULL,
  Id_cliente INT NOT NULL,
  Id_usuario INT NOT NULL,
  CONSTRAINT PK_Venta PRIMARY KEY (Id_venta),
  CONSTRAINT FK_Venta_Cliente FOREIGN KEY (Id_cliente) REFERENCES Cliente(Id_cliente),
  CONSTRAINT FK_Venta_Usuario FOREIGN KEY (Id_usuario) REFERENCES Usuario(Id_usuario)
);

-- Tabla Venta_detalle
CREATE TABLE Venta_detalle
(
  id_venta_detalle INT IDENTITY(1,1) NOT NULL,
  precio FLOAT NOT NULL,
  cantidad INT NOT NULL,
  Id_venta INT NOT NULL,
  Id_producto INT NOT NULL,
  CONSTRAINT PK_Venta_detalle PRIMARY KEY (id_venta_detalle),
  CONSTRAINT FK_Venta_detalle_Venta FOREIGN KEY (Id_venta) REFERENCES Venta(Id_venta),
  CONSTRAINT FK_Venta_detalle_Producto FOREIGN KEY (Id_producto) REFERENCES Producto(Id_producto)
);

-- Tabla Pago
CREATE TABLE Pago
(
  fecha_pago DATE NOT NULL,
  Id_venta INT NOT NULL,
  Id_metodo_pago INT NOT NULL,
  CONSTRAINT PK_Pago PRIMARY KEY (Id_venta, Id_metodo_pago),
  CONSTRAINT FK_Pago_Venta FOREIGN KEY (Id_venta) REFERENCES Venta(Id_venta),
  CONSTRAINT FK_Pago_Metodo_pago FOREIGN KEY (Id_metodo_pago) REFERENCES Metodo_Pago(Id_metodo_pago)
);

INSERT INTO Rol (Rol)
VALUES 
('ADMIN'),
('GERENTE'),
('VENDEDOR');


INSERT INTO Usuario
(Dni, Nombre, Apellido, Correo, Telefono, Sexo, Fecha_Nacimiento, contraseña, baja, Id_rol)
VALUES
(42603123, 'Bruno', 'Marano', 'brunojoelmarano@gmail.com', '1123456789', 'Hombre', '2000-03-13', '12345', 0, 1);

INSERT INTO Usuario
(Dni, Nombre, Apellido, Correo, Telefono, Sexo, Fecha_Nacimiento, contraseña, baja, Id_rol)
VALUES
(37111222, 'Juan', 'Perez', 'juanperez@gmail.com', '1123323443', 'Hombre', '2000-10-13', '12345', 0, 1);

INSERT INTO Usuario
(Dni, Nombre, Apellido, Correo, Telefono, Sexo, Fecha_Nacimiento, contraseña, baja, Id_rol)
VALUES
(37333444, 'Marcos', 'Paz', 'marcospaz@gmail.com', '1123325555', 'Hombre', '2000-10-25', '123', 0, 2);

INSERT INTO Usuario
(Dni, Nombre, Apellido, Correo, Telefono, Sexo, Fecha_Nacimiento, contraseña, baja, Id_rol)
VALUES
(37111555, 'Carlos', 'Garcia', 'carlosgarcia@gmail.com', '1123321111', 'Hombre', '2000-01-14', '111', 0, 3);

EXEC sp_rename 'Producto.Descripción', 'descripcion', 'COLUMN';

-- Modificar los nombres de los campos de la tabla cliente y agregar campos
EXEC sp_rename 'Cliente.Nombre', 'nombre', 'COLUMN';
EXEC sp_rename 'Cliente.Cuit', 'dni', 'COLUMN';
EXEC sp_rename 'Cliente.Telefono', 'telefono', 'COLUMN';
EXEC sp_rename 'Cliente.Direccion', 'direccion', 'COLUMN';
EXEC sp_rename 'Cliente.Id_cliente', 'id_cliente', 'COLUMN';
EXEC sp_rename 'Cliente.Nombre', 'nombre', 'COLUMN';

ALTER TABLE Cliente
ADD apellido VARCHAR (100) NULL,
	email VARCHAR(100) NULL,
	fecha_nacimiento DATE,
	estado BIT DEFAULT 1;

ALTER TABLE Cliente
ADD Id_cliente INT IDENTITY(1,1) NOT NULL;

SELECT * FROM Cliente;

ALTER TABLE Cliente
DROP CONSTRAINT PK_Cliente;

ALTER TABLE Venta
DROP CONSTRAINT FK_Venta_Cliente;

ALTER TABLE Cliente
ADD CONSTRAINT PK_Cliente PRIMARY KEY (Id_cliente);

ALTER TABLE Cliente
DROP COLUMN id_cliente;

INSERT INTO Provincia (provincia) VALUES
('Buenos Aires'),
('Catamarca'),
('Chaco'),
('Chubut'),
('Córdoba'),
('Corrientes'),
('Entre Ríos'),
('Formosa'),
('Jujuy'),
('La Pampa'),
('La Rioja'),
('Mendoza'),
('Misiones'),
('Neuquén'),
('Río Negro'),
('Salta'),
('San Juan'),
('San Luis'),
('Santa Cruz'),
('Santa Fe'),
('Santiago del Estero'),
('Tierra del Fuego, Antártida e Islas del Atlántico Sur'),
('Tucumán');

-- Corrientes (id_provincia = ?)
INSERT INTO Ciudad (ciudad, id_provincia) VALUES
('Corrientes Capital', (SELECT id_provincia FROM Provincia WHERE provincia = 'Corrientes')),
('Goya', (SELECT id_provincia FROM Provincia WHERE provincia = 'Corrientes')),
('Bella Vista', (SELECT id_provincia FROM Provincia WHERE provincia = 'Corrientes')),
('Mercedes', (SELECT id_provincia FROM Provincia WHERE provincia = 'Corrientes')),
('Paso de los Libres', (SELECT id_provincia FROM Provincia WHERE provincia = 'Corrientes'));

-- Chaco
INSERT INTO Ciudad (ciudad, id_provincia) VALUES
('Resistencia', (SELECT id_provincia FROM Provincia WHERE provincia = 'Chaco')),
('Presidencia Roque Sáenz Peña', (SELECT id_provincia FROM Provincia WHERE provincia = 'Chaco')),
('Villa Ángela', (SELECT id_provincia FROM Provincia WHERE provincia = 'Chaco')),
('Charata', (SELECT id_provincia FROM Provincia WHERE provincia = 'Chaco')),
('Las Breñas', (SELECT id_provincia FROM Provincia WHERE provincia = 'Chaco'));

-- Buenos Aires
INSERT INTO Ciudad (ciudad, id_provincia) VALUES
('La Plata', (SELECT id_provincia FROM Provincia WHERE provincia = 'Buenos Aires')),
('Mar del Plata', (SELECT id_provincia FROM Provincia WHERE provincia = 'Buenos Aires')),
('Bahía Blanca', (SELECT id_provincia FROM Provincia WHERE provincia = 'Buenos Aires')),
('Tandil', (SELECT id_provincia FROM Provincia WHERE provincia = 'Buenos Aires')),
('San Nicolás de los Arroyos', (SELECT id_provincia FROM Provincia WHERE provincia = 'Buenos Aires'));

-- Santa Fe
INSERT INTO Ciudad (ciudad, id_provincia) VALUES
('Santa Fe', (SELECT id_provincia FROM Provincia WHERE provincia = 'Santa Fe')),
('Rosario', (SELECT id_provincia FROM Provincia WHERE provincia = 'Santa Fe')),
('Rafaela', (SELECT id_provincia FROM Provincia WHERE provincia = 'Santa Fe')),
('Venado Tuerto', (SELECT id_provincia FROM Provincia WHERE provincia = 'Santa Fe')),
('Reconquista', (SELECT id_provincia FROM Provincia WHERE provincia = 'Santa Fe'));

-- Córdoba
INSERT INTO Ciudad (ciudad, id_provincia) VALUES
('Córdoba Capital', (SELECT id_provincia FROM Provincia WHERE provincia = 'Córdoba')),
('Villa María', (SELECT id_provincia FROM Provincia WHERE provincia = 'Córdoba')),
('Río Cuarto', (SELECT id_provincia FROM Provincia WHERE provincia = 'Córdoba')),
('San Francisco', (SELECT id_provincia FROM Provincia WHERE provincia = 'Córdoba')),
('Villa Carlos Paz', (SELECT id_provincia FROM Provincia WHERE provincia = 'Córdoba'));

SELECT c.ciudad, p.provincia
FROM Ciudad c
INNER JOIN Provincia p ON c.id_provincia = p.id_provincia
ORDER BY p.provincia, c.ciudad;

SELECT * FROM Cliente;

SELECT * FROM Cliente ORDER BY Id_cliente DESC;

ALTER TABLE Usuario
ADD direccion VARCHAR(200);

ALTER TABLE Proveedor
ADD estado DATE NOT NULL;

ALTER TABLE Venta
ADD CONSTRAINT FK_Venta_Usuario
FOREIGN KEY (Id_usuario)
REFERENCES Usuario(Id_usuario);

ALTER TABLE Venta
ADD numero_factura INT NOT NULL;

ALTER TABLE Venta_detalle
ADD subtotal FLOAT NOT NULL;

SELECT * FROM Cliente;

INSERT INTO Categoria (descripcion, activo) VALUES
('Huevos', 1),
('Aves frescas', 1),
('Procesados avicolas', 1),
('Lacteos y fiambres', 1);

CREATE TABLE TipoProducto (
id_tipo INT PRIMARY KEY IDENTITY(1,1),
nombre VARCHAR(100) NOT NULL,
id_categoria INT NOT NULL,
FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria));

CREATE TABLE Categoria (
    id_categoria INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL
);

CREATE TABLE TipoProducto (
    id_tipo INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    id_categoria INT NOT NULL,
    FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria)
);

-- CATEGORÍAS
INSERT INTO Categoria (nombre) VALUES
('Aves'),
('Huevos'),
('Fiambres'),
('Lácteos');

-- PRODUCTOS SEGÚN CATEGORÍA
INSERT INTO TipoProducto (nombre, id_categoria, estado) VALUES
('Pollo entero fresco', 1, 1),
('Pechuga de pollo', 1, 1),
('Muslo de pollo', 1, 1),
('Huevo blanco docena', 2, 1),
('Huevo colorado docena', 2, 1),
('Queso cremoso', 4, 1),
('Queso rallado', 4, 1),
('Salame milán', 3, 1),
('Jamón cocido', 3, 1);

EXEC sp_rename 'Categoria.activo', 'estado', 'COLUMN';
DELETE FROM TipoProducto;
SELECT * FROM Categoria;

ALTER TABLE TipoProducto
ADD estado BIT NOT NULL DEFAULT 1;

SELECT * FROM TipoProducto;
SELECT * FROM Categoria;

ALTER TABLE Proveedor
DROP COLUMN estado;

ALTER TABLE Proveedor
ADD estado BIT NOT NULL DEFAULT 1;

INSERT INTO Proveedor (nombre, cuit, direccion, telefono, email, fecha_registro, id_ciudad, estado)
VALUES
('Distribuciones Avícolas Corrientes S.A.', '30123456789', 'Av. Independencia 1023', '3794441122', 'contacto@davicor.com.ar', GETDATE(), 1, 1),
('Proveedora El Pollo Feliz', '30876543210', 'Ruta 12 km 45', '3795553344', 'ventas@pollofeliz.com.ar', GETDATE(), 2, 1),
('Alimentos del Norte S.R.L.', '30112233445', 'B° Industrial', '3796667788', 'info@alimentosdelnorte.com.ar', GETDATE(), 3, 1),
('Insumos Avícolas del Litoral', '30556677881', 'Acceso Sur 760', '3797779900', 'contacto@insumoslitoral.com.ar', GETDATE(), 1, 1),
('Fríos & Procesados del Sur S.A.', '30998877663', 'Ruta 12 km 10', '3798881100', 'ventas@friosyprocesados.com.ar', GETDATE(), 2, 1),
('Huevo Premium Corrientes', '30443322116', 'Av. Maipú 4500', '3799992233', 'info@huevopremium.com.ar', GETDATE(), 3, 1),
('Cárnicos Tropicales S.A.', '30667788992', 'Ruta 12 km 60', '3793334455', 'ventas@carnicostropicales.com.ar', GETDATE(), 1, 1),
('Góndola Selecta Corrientes', '30224466884', 'Av. 9 de Julio 520', '3792223344', 'info@gondolaselecta.com.ar', GETDATE(), 2, 1),
('Distribuidora de Embutidos del Norte', '30445566770', 'B° Gomez', '3797772233', 'contacto@embutidosnorte.com.ar', GETDATE(), 3, 1),
('Proveedor Integral Avícola S.A.', '30889900118', 'Zona Franca Corrientes', '3791116655', 'info@proveedorintegral.com.ar', GETDATE(), 2, 1);

ALTER TABLE Producto
ADD CONSTRAINT FK_id_tipo
FOREIGN KEY (id_tipo)
REFERENCES tipoProducto(id_tipo);

INSERT INTO Producto (precio, stock, stock_minimo, estado, id_tipo)
VALUES 
(2200, 50, 15, 1, 1),
(2300, 80, 150, 1, 2),
(1800, 20, 8, 1, 3),
(2500, 35, 10, 1, 4),
(2700, 40, 20, 1, 5),
(2000, 25, 15, 1, 1),
(2600, 60, 150, 1, 2),
(2100, 18, 8, 1, 3),
(3000, 45, 10, 1, 4),
(3200, 55, 20, 1, 5);


