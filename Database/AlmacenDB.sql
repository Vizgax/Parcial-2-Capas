/* =====================================================================
   Contenido:
     1. Base de datos
     2. Tablas
     3. Datos de ejemplo (usuarios con hash PBKDF2, productos)
     4. Procedimientos almacenados (la app SOLO usa estos)
     5. Login/Usuario de la aplicación con PRIVILEGIOS MÍNIMOS
   ===================================================================== */

USE master;
GO

IF DB_ID(N'AlmacenDB') IS NULL
    CREATE DATABASE AlmacenDB;
GO

USE AlmacenDB;
GO

/* =====================================================================
   2. TABLAS
   ===================================================================== */

IF OBJECT_ID(N'dbo.Roles', N'U') IS NULL
CREATE TABLE dbo.Roles
(
    IdRol   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Roles PRIMARY KEY,
    Nombre  NVARCHAR(30)      NOT NULL CONSTRAINT UQ_Roles_Nombre UNIQUE
);
GO

IF OBJECT_ID(N'dbo.Usuarios', N'U') IS NULL
CREATE TABLE dbo.Usuarios
(
    IdUsuario       INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Usuarios PRIMARY KEY,
    NombreUsuario   NVARCHAR(50)      NOT NULL CONSTRAINT UQ_Usuarios_NombreUsuario UNIQUE,
    NombreCompleto  NVARCHAR(100)     NOT NULL,
    -- Formato: iteraciones.salt(Base64).hash(Base64)   (PBKDF2-HMAC-SHA256)
    PasswordHash    NVARCHAR(256)     NOT NULL,
    IdRol           INT               NOT NULL CONSTRAINT FK_Usuarios_Roles REFERENCES dbo.Roles(IdRol),
    Activo          BIT               NOT NULL CONSTRAINT DF_Usuarios_Activo DEFAULT (1),
    FechaCreacion   DATETIME2(0)      NOT NULL CONSTRAINT DF_Usuarios_Fecha  DEFAULT (SYSDATETIME())
);
GO

IF OBJECT_ID(N'dbo.Categorias', N'U') IS NULL
CREATE TABLE dbo.Categorias
(
    IdCategoria INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Categorias PRIMARY KEY,
    Nombre      NVARCHAR(60)      NOT NULL CONSTRAINT UQ_Categorias_Nombre UNIQUE
);
GO

IF OBJECT_ID(N'dbo.Proveedores', N'U') IS NULL
CREATE TABLE dbo.Proveedores
(
    IdProveedor INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Proveedores PRIMARY KEY,
    Nombre      NVARCHAR(100)     NOT NULL CONSTRAINT UQ_Proveedores_Nombre UNIQUE,
    Telefono    NVARCHAR(20)      NULL,
    Correo      NVARCHAR(100)     NULL
);
GO

IF OBJECT_ID(N'dbo.Productos', N'U') IS NULL
CREATE TABLE dbo.Productos
(
    IdProducto   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Productos PRIMARY KEY,
    Codigo       NVARCHAR(20)      NOT NULL CONSTRAINT UQ_Productos_Codigo UNIQUE,
    Nombre       NVARCHAR(120)     NOT NULL,
    IdCategoria  INT               NOT NULL CONSTRAINT FK_Productos_Categorias  REFERENCES dbo.Categorias(IdCategoria),
    IdProveedor  INT               NOT NULL CONSTRAINT FK_Productos_Proveedores REFERENCES dbo.Proveedores(IdProveedor),
    Precio       DECIMAL(10,2)     NOT NULL CONSTRAINT CK_Productos_Precio CHECK (Precio >= 0),
    Stock        INT               NOT NULL CONSTRAINT CK_Productos_Stock  CHECK (Stock  >= 0),
    StockMinimo  INT               NOT NULL CONSTRAINT DF_Productos_StockMin DEFAULT (5),
    Activo       BIT               NOT NULL CONSTRAINT DF_Productos_Activo   DEFAULT (1)
);
GO

/* =====================================================================
   3. DATOS DE EJEMPLO
   ===================================================================== */

-- Roles
INSERT INTO dbo.Roles (Nombre)
SELECT v.Nombre FROM (VALUES (N'Admin'), (N'Usuario')) AS v(Nombre)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Roles r WHERE r.Nombre = v.Nombre);
GO

/* Usuarios de prueba.  Las contraseñas están guardadas como HASH (PBKDF2),
   nunca en texto plano:
        admin   ->  Admin123*      (rol Admin)
        jperez  ->  Usuario123*    (rol Usuario)
        mgomez  ->  Usuario123*    (rol Usuario)                          */
INSERT INTO dbo.Usuarios (NombreUsuario, NombreCompleto, PasswordHash, IdRol)
SELECT v.NombreUsuario, v.NombreCompleto, v.PasswordHash, r.IdRol
FROM (VALUES
    (N'admin',  N'Administrador del Sistema', N'100000.lYmI+ZCblEr4OsfMdd8eRA==.9IfT5y9tazX/c0X4EkxRDxqqTkMkmnmZ/AFAT/a/XjU=', N'Admin'),
    (N'jperez', N'Juan Pérez',                N'100000.MQ22VYk8zHwt8I4fYLbh2A==.0XXxExWSNX3kBtyWWxx9+1lPbpOJXDyf+x2+JDykI/c=', N'Usuario'),
    (N'mgomez', N'María Gómez',               N'100000.r8qX/KupvgD42xZgXTSU0g==.s0t7wtsMNiAJKjj0lSm1BuUMH3FpeM4er3Q54FHuszg=', N'Usuario')
) AS v(NombreUsuario, NombreCompleto, PasswordHash, Rol)
JOIN dbo.Roles r ON r.Nombre = v.Rol
WHERE NOT EXISTS (SELECT 1 FROM dbo.Usuarios u WHERE u.NombreUsuario = v.NombreUsuario);
GO

-- Categorías
INSERT INTO dbo.Categorias (Nombre)
SELECT v.Nombre FROM (VALUES
    (N'Herramientas'), (N'Electrónica'), (N'Papelería'), (N'Limpieza'), (N'Alimentos no perecederos')
) AS v(Nombre)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Categorias c WHERE c.Nombre = v.Nombre);
GO

-- Proveedores
INSERT INTO dbo.Proveedores (Nombre, Telefono, Correo)
SELECT v.Nombre, v.Telefono, v.Correo FROM (VALUES
    (N'Distribuidora Istmo S.A.',   N'507-221-1010', N'ventas@istmo.com.pa'),
    (N'TecnoPanamá Corp.',          N'507-264-2020', N'contacto@tecnopanama.com'),
    (N'Papelera del Canal',         N'507-236-3030', N'pedidos@papeleracanal.com'),
    (N'Suministros Bahía',          N'507-227-4040', N'info@suministrosbahia.com')
) AS v(Nombre, Telefono, Correo)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Proveedores p WHERE p.Nombre = v.Nombre);
GO

-- Productos
INSERT INTO dbo.Productos (Codigo, Nombre, IdCategoria, IdProveedor, Precio, Stock, StockMinimo)
SELECT v.Codigo, v.Nombre, c.IdCategoria, p.IdProveedor, v.Precio, v.Stock, v.StockMinimo
FROM (VALUES
    (N'HER-001', N'Martillo de acero 16 oz',         N'Herramientas',  N'Distribuidora Istmo S.A.',  12.50,  40, 10),
    (N'HER-002', N'Destornillador Phillips #2',      N'Herramientas',  N'Distribuidora Istmo S.A.',   4.75,  85, 20),
    (N'HER-003', N'Taladro inalámbrico 20V',         N'Herramientas',  N'Distribuidora Istmo S.A.', 89.99,   6,  8),
    (N'HER-004', N'Cinta métrica 5 m',               N'Herramientas',  N'Suministros Bahía',          3.25, 120, 25),
    (N'ELE-001', N'Cable HDMI 2 m',                  N'Electrónica',   N'TecnoPanamá Corp.',          7.90,  60, 15),
    (N'ELE-002', N'Mouse inalámbrico USB',           N'Electrónica',   N'TecnoPanamá Corp.',         11.99,  35, 10),
    (N'ELE-003', N'Teclado USB en español',          N'Electrónica',   N'TecnoPanamá Corp.',         15.50,   4, 10),
    (N'ELE-004', N'Memoria USB 64 GB',               N'Electrónica',   N'TecnoPanamá Corp.',          8.75,  70, 20),
    (N'PAP-001', N'Resma de papel carta (500 hojas)',N'Papelería',     N'Papelera del Canal',         5.95, 200, 50),
    (N'PAP-002', N'Caja de bolígrafos azules (12)',  N'Papelería',     N'Papelera del Canal',         3.40,  90, 30),
    (N'PAP-003', N'Cuaderno universitario 100 h',    N'Papelería',     N'Papelera del Canal',         1.85,   3, 40),
    (N'LIM-001', N'Cloro galón',                     N'Limpieza',      N'Suministros Bahía',          3.10,  55, 20),
    (N'LIM-002', N'Desinfectante multiuso 1 L',      N'Limpieza',      N'Suministros Bahía',          2.60,  48, 15),
    (N'LIM-003', N'Escoba plástica',                 N'Limpieza',      N'Suministros Bahía',          4.20,   5, 12),
    (N'ALI-001', N'Arroz blanco 5 lb',               N'Alimentos no perecederos', N'Distribuidora Istmo S.A.', 3.85, 150, 40),
    (N'ALI-002', N'Atún en lata 140 g',              N'Alimentos no perecederos', N'Distribuidora Istmo S.A.', 1.25, 300, 80)
) AS v(Codigo, Nombre, Categoria, Proveedor, Precio, Stock, StockMinimo)
JOIN dbo.Categorias  c ON c.Nombre = v.Categoria
JOIN dbo.Proveedores p ON p.Nombre = v.Proveedor
WHERE NOT EXISTS (SELECT 1 FROM dbo.Productos x WHERE x.Codigo = v.Codigo);
GO

/* =====================================================================
   4. PROCEDIMIENTOS ALMACENADOS
   (Toda la comunicación de la aplicación con la BD pasa por aquí)
   ===================================================================== */

-- Devuelve un usuario por su nombre de usuario (incluye el hash para verificarlo en la capa de Negocio)
CREATE OR ALTER PROCEDURE dbo.sp_Usuario_ObtenerPorNombre
    @NombreUsuario NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT u.IdUsuario, u.NombreUsuario, u.NombreCompleto, u.PasswordHash,
           r.Nombre AS Rol, u.Activo, u.FechaCreacion
    FROM   dbo.Usuarios u
    INNER JOIN dbo.Roles r ON r.IdRol = u.IdRol
    WHERE  u.NombreUsuario = @NombreUsuario;
END
GO

-- Lista de usuarios para el administrador (NUNCA devuelve el hash)
CREATE OR ALTER PROCEDURE dbo.sp_Usuario_Listar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT u.IdUsuario, u.NombreUsuario, u.NombreCompleto,
           r.Nombre AS Rol, u.Activo, u.FechaCreacion
    FROM   dbo.Usuarios u
    INNER JOIN dbo.Roles r ON r.IdRol = u.IdRol
    ORDER BY u.NombreUsuario;
END
GO

-- Guarda el nuevo hash de la contraseña (el hash se genera en la capa de Negocio)
CREATE OR ALTER PROCEDURE dbo.sp_Usuario_ActualizarPassword
    @IdUsuario    INT,
    @PasswordHash NVARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Usuarios
    SET    PasswordHash = @PasswordHash
    WHERE  IdUsuario = @IdUsuario AND Activo = 1;

    SELECT @@ROWCOUNT AS FilasAfectadas;
END
GO

-- Lista todos los productos activos
CREATE OR ALTER PROCEDURE dbo.sp_Producto_Listar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.IdProducto, p.Codigo, p.Nombre,
           c.Nombre AS Categoria, pr.Nombre AS Proveedor,
           p.Precio, p.Stock, p.StockMinimo
    FROM   dbo.Productos p
    INNER JOIN dbo.Categorias  c  ON c.IdCategoria  = p.IdCategoria
    INNER JOIN dbo.Proveedores pr ON pr.IdProveedor = p.IdProveedor
    WHERE  p.Activo = 1
    ORDER BY p.Nombre;
END
GO

-- Busca productos activos cuyo nombre contenga el texto indicado
CREATE OR ALTER PROCEDURE dbo.sp_Producto_BuscarPorNombre
    @Nombre NVARCHAR(120)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT p.IdProducto, p.Codigo, p.Nombre,
           c.Nombre AS Categoria, pr.Nombre AS Proveedor,
           p.Precio, p.Stock, p.StockMinimo
    FROM   dbo.Productos p
    INNER JOIN dbo.Categorias  c  ON c.IdCategoria  = p.IdCategoria
    INNER JOIN dbo.Proveedores pr ON pr.IdProveedor = p.IdProveedor
    WHERE  p.Activo = 1
      AND  p.Nombre LIKE N'%' + @Nombre + N'%'
    ORDER BY p.Nombre;
END
GO

/* =====================================================================
   5. LOGIN / USUARIO DE LA APLICACIÓN  -  PRIVILEGIOS MÍNIMOS
   ---------------------------------------------------------------------
   La aplicación NO se conecta como 'sa' ni como dbo. Usa 'almacen_app',
   que solamente puede EJECUTAR los 5 procedimientos de arriba:
     - No puede hacer SELECT/INSERT/UPDATE/DELETE directo sobre tablas.
     - No puede crear, alterar ni borrar objetos.
   (Los SP acceden a las tablas por "ownership chaining": mismo dueño dbo.)
   ===================================================================== */

USE master;
GO

IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'almacen_app')
    CREATE LOGIN almacen_app
        WITH PASSWORD = N'Alm@cen_App#2026',
             DEFAULT_DATABASE = AlmacenDB,
             CHECK_POLICY = ON,
             CHECK_EXPIRATION = OFF;
GO

USE AlmacenDB;
GO

IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N'almacen_app')
    CREATE USER almacen_app FOR LOGIN almacen_app WITH DEFAULT_SCHEMA = dbo;
GO

IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N'rol_app_almacen' AND type = 'R')
    CREATE ROLE rol_app_almacen;
GO

-- Solo EXECUTE sobre los procedimientos que la aplicación necesita
GRANT EXECUTE ON OBJECT::dbo.sp_Usuario_ObtenerPorNombre  TO rol_app_almacen;
GRANT EXECUTE ON OBJECT::dbo.sp_Usuario_Listar            TO rol_app_almacen;
GRANT EXECUTE ON OBJECT::dbo.sp_Usuario_ActualizarPassword TO rol_app_almacen;
GRANT EXECUTE ON OBJECT::dbo.sp_Producto_Listar           TO rol_app_almacen;
GRANT EXECUTE ON OBJECT::dbo.sp_Producto_BuscarPorNombre  TO rol_app_almacen;

-- Acceso directo a tablas explícitamente denegado
DENY SELECT, INSERT, UPDATE, DELETE, ALTER, REFERENCES ON SCHEMA::dbo TO rol_app_almacen;
GO

ALTER ROLE rol_app_almacen ADD MEMBER almacen_app;
GO

PRINT N'AlmacenDB lista. Usuarios: admin / Admin123*  |  jperez / Usuario123*  |  mgomez / Usuario123*';
GO