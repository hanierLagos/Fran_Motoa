USE master
GO

CREATE DATABASE TALLER_FRANC
GO

USE  TALLER_FRANC
GO
-- Tabla Clientes
CREATE TABLE CLIENTES(
    ID_CLIENTE INT PRIMARY KEY  IDENTITY(1,1),
    CODIGO_CLIENTE CHAR(6) NOT NULL,
    NOMBRES VARCHAR(100) NOT NULL,
    APELLIDOS VARCHAR(100) NOT NULL,
    TELEFONO VARCHAR(20) NULL ,
    DIRECCION VARCHAR(255) NULL,
	ESTADO SMALLINT NOT NULL
);
GO

-- Tabla Marcas
CREATE TABLE MARCAS(
    ID_MARCA INT PRIMARY KEY IDENTITY(1,1),
    CODIGO_MARCA VARCHAR(8) NOT NULL,
    NOMBRE_MARCA VARCHAR(100) NOT NULL
);
GO

-- Tabla Categorias
CREATE TABLE CATEGORIAS(
    ID_CATEGORIA INT PRIMARY KEY IDENTITY(1,1),
    CODIGO_CATEGORIA VARCHAR(10) NOT NULL,
    NOMBRE_CATEGORIA VARCHAR(100) NOT NULL
);
GO

-- Tabla Productos
CREATE TABLE PRODUCTOS(
    ID_PRODUCTO INT PRIMARY KEY  IDENTITY(1,1),
    CODIGO_PRODUCTO VARCHAR(10) NOT NULL,
    NOMBRE_PRODUCT VARCHAR(100) NOT NULL,
    PRECIO_PRODUCTO DECIMAL(10,2) NOT NULL,
    ID_MARCA INT NOT NULL,
    ID_CATEGORIA INT NOT NULL,
    ESTADO VARCHAR(50) NOT NULL,
		CANTIDAD DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_MARCAS_PRODUCTOS FOREIGN KEY (ID_MARCA) REFERENCES MARCAS(ID_MARCA),
    CONSTRAINT FK_CATEGORIAS_PRODUCTOS FOREIGN KEY (ID_CATEGORIA) REFERENCES CATEGORIAS(ID_CATEGORIA)
);
GO

CREATE TABLE [dbo].[INVENTARIO_ENTRADAS](
    [ID_ENTRADA] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,  -- Clave primaria
		NUMERO_ENTRADA INT NOT NULL,
    [FECHA_ENTRADA] [datetime] NOT NULL ,
	DESCRIPCION VARCHAR(MAX)-- Fecha de la entrada
);
GO

CREATE TABLE [dbo].[DETALLE_ENTRADA](
    [ID_DETALLE_ENTRADA] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY, -- Clave primaria
    [ID_ENTRADA] [int] NOT NULL,                                   -- Relaciona con la tabla de entradas
    [ID_PRODUCTO] [int] NOT NULL,                                  -- Relaciona con la tabla de productos
    [CANTIDAD] DECIMAL(10,2) NOT NULL,                                     -- Cantidad de productos en la entrada
    [PRECIO_ENTRADA] [decimal](10,2) NOT NULL,                     -- Precio de compra del producto
    [PRECIO_VENTA] [decimal](10,2) NOT NULL                        -- Precio de venta del producto
);
GO

-- Establecer las llaves foráneas
ALTER TABLE [dbo].[DETALLE_ENTRADA] 
ADD CONSTRAINT FK_ENTRADA_DETALLE 
FOREIGN KEY (ID_ENTRADA) REFERENCES INVENTARIO_ENTRADAS(ID_ENTRADA),
CONSTRAINT FK_PRODUCTO_DETALLE 
FOREIGN KEY (ID_PRODUCTO) REFERENCES PRODUCTOS(ID_PRODUCTO);
GO

-- Tabla Ventas
CREATE TABLE VENTAS(
    ID_VENTA INT PRIMARY KEY IDENTITY(1,1),
    NUMERO_VENTA INT NOT NULL,
    ID_CLIENTE INT NOT NULL,
    FECHA_VENTA DATETIME NOT NULL,
    MONTO_TOTAL DECIMAL(10, 2) NOT NULL,
		METODO_PAGO VARCHAR(50) NOT NULL,
	ESTADO VARCHAR(50) NOT NULL,
     CONSTRAINT FK_CLIENTES_VENTAS FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTES(ID_CLIENTE)
);
GO

-- Tabla Detalle_Ventas
CREATE TABLE DETALLE_VENTAS(
    ID_DETALLE_VENTA INT PRIMARY KEY IDENTITY(1,1),
    ID_VENTA INT NOT NULL,
    ID_PRODUCTO INT NOT NULL,
    CANTIDAD DECIMAL(10,2) NOT NULL,
    PRECIO_UNITARIO DECIMAL(10, 2) NOT NULL,
    SUBTOTAL DECIMAL(10, 2) NOT NULL,
		DESCRIPCION VARCHAR(100) NOT NULL,
    CONSTRAINT FK_VENTAS_DETALLE FOREIGN KEY(ID_VENTA) REFERENCES VENTAS(ID_VENTA),
    CONSTRAINT FK_PRODUCTOS_DETALLE FOREIGN KEY (ID_PRODUCTO) REFERENCES PRODUCTOS(ID_PRODUCTO)
);
GO
 
CREATE TABLE USUARIOS(
ID_USUARIO INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
CODIGO_USUARIO CHAR(6) NOT NULL,
ROL VARCHAR(18) NOT NULL,
NOMBRES VARCHAR(100) NOT NULL,
APELLIDOS VARCHAR(100) NOT NULL,
USUARIO VARCHAR(10) NOT NULL,
CONTRASENA VARCHAR(12) NOT NULL,
ESTADO SMALLINT NOT NULL
)
GO
CREATE TABLE TIPO_MANO_OBRA(
ID_TIPO_MANO_OBRA INT PRIMARY KEY IDENTITY(1,1),
NOMBRE_TIPO VARCHAR(100) NOT NULL
)
GO

CREATE TABLE DETALLE_MANO_OBRA(
ID_DETALLE_MANO_OBRA INT NOT NULL PRIMARY KEY IDENTITY(1,1),
ID_VENTA INT NOT NULL,
ID_TIPO_MANO_OBRA INT NOT NULL,
DESCRIPCION VARCHAR(255) NOT NULL,
PRECIO_MANO_DE_OBRA DECIMAL(10,2),
CONSTRAINT FK_VENTAS_DETALLEOBRA FOREIGN KEY (ID_VENTA) REFERENCES VENTAS(ID_VENTA),
CONSTRAINT FK_TIPOOBRA_DETALLE FOREIGN KEY (ID_TIPO_MANO_OBRA) REFERENCES TIPO_MANO_OBRA (ID_TIPO_MANO_OBRA)
)
GO


USE TALLER_FRANC
GO


--PROCEDIMEINT PARA AGREGAR UN PRODUCTO

CREATE OR ALTER PROCEDURE [dbo].[Us_AgregarProducto]
    @codigo CHAR(10) ,
    @nombre VARCHAR(100),
    @precio DECIMAL(10,2),
    @marcaid INT,
    @categoriaid INT,
    @cantidad DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Insertar un nuevo registro en la tabla Productos
        INSERT INTO PRODUCTOS (CODIGO_PRODUCTO, NOMBRE_PRODUCT, PRECIO_PRODUCTO, ID_MARCA, ID_CATEGORIA, CANTIDAD,ESTADO)
        VALUES (@codigo, @nombre, @precio, @marcaid, @categoriaid, @cantidad, 'ACTIVO');
    END TRY
    BEGIN CATCH
        -- Manejo de errores con más detalles
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END;
GO
--PROCEDIMIENTO PARA ACTUALIZAR PRODUCTO
CREATE OR ALTER   PROCEDURE [dbo].[Us_ActualizarProducto]
    @codigo CHAR(10) ,
    @nombre VARCHAR(100),
    @precio DECIMAL(10,2),
    @marcaid INT,
    @categoriaid INT,
    @cantidad DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Actualizar los datos del producto
        UPDATE PRODUCTOS
        SET NOMBRE_PRODUCT = @nombre,
            PRECIO_PRODUCTO = @precio,
            ID_MARCA = @marcaid,
            ID_CATEGORIA = @categoriaid, 
            CANTIDAD = @cantidad,
            ESTADO = 'ACTIVO'
        WHERE CODIGO_PRODUCTO = @codigo;

        -- Validación: Si no se actualizó ninguna fila
        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No se encontró ningún producto con el código especificado.', 16, 1);
        END
    END TRY
    BEGIN CATCH
        -- Manejo de errores con más detalles
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END;
GO

--PROCEDIMIENTO PARA ACTUALIZAR LOS PODUCTOS AL INVENTARIO
CREATE OR ALTER PROCEDURE [dbo].[Us_ActualizarProductoEntrada]
    @codigo CHAR(10) ,
    @nombre VARCHAR(100),
    @precio DECIMAL(10,2),
    @marcaid INT,
    @categoriaid INT,
    @cantidad DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Actualizar los datos del producto
        UPDATE PRODUCTOS
        SET NOMBRE_PRODUCT = @nombre,
            PRECIO_PRODUCTO = @precio,
            ID_MARCA = @marcaid,
            ID_CATEGORIA = @categoriaid, 
            @cantidad=CANTIDAD = CANTIDAD+ @cantidad,
            ESTADO = 'ACTIVO'
        WHERE CODIGO_PRODUCTO = @codigo;

        -- Validación: Si no se actualizó ninguna fila
        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No se encontró ningún producto con el código especificado.', 16, 1);
        END
    END TRY
    BEGIN CATCH
        -- Manejo de errores con más detalles
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END;
GO

--PROCEDIMIENTO PARA CARGAR CLIENTES EN COMB0BOX, ADEMAS PAAR OBTENER EL ID DEL CLIENTE
CREATE OR ALTER PROCEDURE Us_VerClientesEnVenta
AS
BEGIN
	SELECT ID_CLIENTE, CODIGO_CLIENTE+ ' - ' + NOMBRES + ' ' +APELLIDOS AS CLIENTE
	FROM CLIENTES
	ORDER BY ID_CLIENTE DESC
END
GO

--PRCEDIMIENTO PARA LEER PRODUCTO
CREATE OR ALTER PROCEDURE [dbo].[Us_ReadProducto]
	@codigo CHAR(10) 
AS
BEGIN
	SELECT P.CODIGO_PRODUCTO,
		   P.NOMBRE_PRODUCT,
		   P.PRECIO_PRODUCTO,
		   P.ID_MARCA,
		   P.ID_CATEGORIA,
		   P.CANTIDAD
	FROM PRODUCTOS P
	WHERE CODIGO_PRODUCTO = @codigo
END
GO

--PROCEDIMIENTO PARA CARGAR Y OBTENER EL ID DEL TIPO DE MANO DE OBRA
CREATE OR ALTER PROCEDURE Us_CargarTipoManoObra
AS
BEGIN
	SELECT ID_TIPO_MANO_OBRA , NOMBRE_TIPO FROM TIPO_MANO_OBRA
END
GO

--PROCEDIMIENTO ALMACENADO PARAVER PRODUCTOS EN LA TABLA
CREATE OR ALTER PROCEDURE [dbo].[Us_LeerProducto]
    @codigo CHAR(10) 
AS
BEGIN
    SELECT 
        P.CODIGO_PRODUCTO,
        P.NOMBRE_PRODUCT,
        P.PRECIO_PRODUCTO,
        M.NOMBRE_MARCA,
        C.NOMBRE_CATEGORIA,
        P.CANTIDAD
	FROM PRODUCTOS P
    INNER JOIN MARCAS M ON M.ID_MARCA = P.ID_MARCA
    INNER JOIN CATEGORIAS C ON C.ID_CATEGORIA = P.ID_CATEGORIA -- Asegúrate de que este ID coincide
    WHERE P.CODIGO_PRODUCTO = @codigo; -- Especifica la tabla en la condición
END
GO

--PRCEDIMIENTO PARA MOSTRAR LA LISTA DE LOS CLIENTES EN UNA TABLA ELIGIENDO LA CANTIDAD
CREATE  OR ALTER PROCEDURE [dbo].[Us_ReadTopProducto] 
	@valuesTop int
	AS
	BEGIN
		-- Evitar la posible interferencia de un conjunto de registros en los resultados de Select
		SET NOCOUNT ON
		SELECT TOP (@valuesTop)
		P.CODIGO_PRODUCTO,
		   P.NOMBRE_PRODUCT,
		   P.PRECIO_PRODUCTO,
		   M.NOMBRE_MARCA,
		   C.NOMBRE_CATEGORIA,
		   P.CANTIDAD
	FROM PRODUCTOS P
	INNER JOIN MARCAS M
	ON M.ID_MARCA=P.ID_MARCA
	INNER JOIN CATEGORIAS C
	ON C.ID_CATEGORIA= P.ID_CATEGORIA
		ORDER BY ID_PRODUCTO DESC
	END

GO

--PROCEDIMIENTO PARA BUSCAR CIENTES POR NOMBRES
CREATE OR ALTER  PROCEDURE Us_BuscarProductoPorNombre
    @NOMBRE VARCHAR(100)
AS
BEGIN
    SELECT P.CODIGO_PRODUCTO,
		   P.NOMBRE_PRODUCT,
		   P.PRECIO_PRODUCTO,
		   M.NOMBRE_MARCA,
		   C.NOMBRE_CATEGORIA,
		   P.CANTIDAD
    FROM PRODUCTOS P
	INNER JOIN MARCAS M
	ON M.ID_MARCA=P.ID_MARCA
	INNER JOIN CATEGORIAS C
	ON C.CODIGO_CATEGORIA= P.ID_CATEGORIA

    WHERE NOMBRE_PRODUCT LIKE '%' + @NOMBRE + '%'	
	OR NOMBRE_MARCA LIKE  '%' + @NOMBRE + '%'	
	OR NOMBRE_CATEGORIA LIKE  '%' + @NOMBRE + '%'	
END
GO

--PROCEDIMIENTO PARA ELIMINAR UN OBJETO CLIENTE
CREATE OR ALTER  PROCEDURE [dbo].[Us_EliminarProducto]
    @codigo varchar(10)
AS
BEGIN
    UPDATE PRODUCTOS SET ESTADO = 'INACTIVO'
    WHERE CODIGO_PRODUCTO = @codigo
END
GO

--PROCEDIMEINTO PARA OBTENER EL ID DE LAS MARCAS
CREATE OR ALTER  PROCEDURE [dbo].[Us_ObtenerIdMarca]
AS
BEGIN
SELECT ID_MARCA, NOMBRE_MARCA
FROM MARCAS
ORDER BY NOMBRE_MARCA DESC
END
GO

--PROCEDIMEINTO PARA OBTENER EL ID DE LAS CTEGORIAS
CREATE OR ALTER  PROCEDURE [dbo].[Us_ObtenerIdCategoria]
AS
BEGIN
SELECT ID_CATEGORIA, NOMBRE_CATEGORIA
FROM CATEGORIAS
ORDER BY NOMBRE_CATEGORIA DESC

END
GO

--PROCEDIMEINTO PARA OBTENER EL PROXIMO NUMERO DE ENTRADA
CREATE  OR ALTER PROCEDURE [dbo].[Us_ObtenerNumeroEntrada]
AS
BEGIN
    DECLARE @SiguienteNumero INT;

    -- Obtener el próximo número de entrada
    SELECT @SiguienteNumero = ISNULL(MAX(NUMERO_ENTRADA), 0) + 1
    FROM INVENTARIO_ENTRADAS;

    -- Retornar el próximo número de factura de compra
    SELECT @SiguienteNumero AS NuevoNumero;
END
GO

--PROCEDIMIENTO PARA AGREGAR NUEVA ENTRADA
CREATE OR ALTER PROCEDURE [dbo].[Us_AgregarEntrada]
    @Numero int ,
    @Fecha DateTime,
    @Description VARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Insertar un nuevo registro en la tabla inventario_entradas
        INSERT INTO INVENTARIO_ENTRADAS(NUMERO_ENTRADA, FECHA_ENTRADA, DESCRIPCION)
        VALUES (@Numero, @Fecha, @Description);
    END TRY
    BEGIN CATCH
        -- Manejo de errores con más detalles
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END;
GO

--PROCEDIMEINTO PARA AZTUALIZAR ENTRADA
CREATE OR ALTER PROCEDURE [dbo].[Us_ActualizarEntrada]
    @Numero int ,
    @Fecha DateTime,
    @Description VARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Actualizar los datos de a entrada
        UPDATE INVENTARIO_ENTRADAS
        SET NUMERO_ENTRADA = @Numero,
            FECHA_ENTRADA = @Fecha,
            DESCRIPCION = @Description
        WHERE NUMERO_ENTRADA = @Numero;

        -- Validación: Si no se actualizó ninguna fila
        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No se encontró ninguna entrada con el numero especificado.', 16, 1);
        END
    END TRY
    BEGIN CATCH
        -- Manejo de errores con más detalles
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END;
GO

--PRCEDIMIENTO PARA LEER ENTRADA
CREATE OR ALTER PROCEDURE [dbo].[Us_ReadEntrada]
	@Numero int 
AS
BEGIN
	SELECT NUMERO_ENTRADA,
		   FECHA_ENTRADA,
		   DESCRIPCION
	FROM INVENTARIO_ENTRADAS 
	WHERE NUMERO_ENTRADA = @Numero
END
GO

--PROCEDIMIENTO PARA OBTENER EL ID DE PRODUCTO 
CREATE OR ALTER PROCEDURE Us_ObtenerIdProducto
AS
BEGIN
SELECT ID_PRODUCTO, CODIGO_PRODUCTO
FROM PRODUCTOS
END 
GO

--PROCEDIMIENTO PARA OBTENER EL ID DE ENTRADA 
CREATE OR ALTER PROCEDURE Us_ObtenerIdEntrada
AS
BEGIN
SELECT ID_ENTRADA, NUMERO_ENTRADA
FROM INVENTARIO_ENTRADAS
END 
GO

--PROCEDIMIENTO PARA GUARDAR DETALLE DE ENTRADA
CREATE OR ALTER PROCEDURE Us_AgregarDetalleEntrada
@IdEntrada int,
@IdProducto int,
@Cantidad DECIMAL(10,2),
@PrecioEntrada decimal(10,2),
@PrecioVenta decimal(10,2)
AS
BEGIN
	INSERT INTO DETALLE_ENTRADA(ID_ENTRADA, ID_PRODUCTO, CANTIDAD, PRECIO_ENTRADA, PRECIO_VENTA)
	VALUES(@IdEntrada, @IdProducto, @Cantidad, @PrecioEntrada, @PrecioVenta)
END
GO

--PROCEDIMIENTO PARA VER LAS ENTRADAS Y CUANTOS PRODUCTOS ENTRAON Y LOS NOMBRES DE LOS PRODUCTOS
CREATE OR ALTER PROCEDURE Us_VerEntradas
AS
BEGIN
   SELECT IE.NUMERO_ENTRADA,
		  IE.FECHA_ENTRADA,
          STRING_AGG(P.NOMBRE_PRODUCT + ' ' + M.NOMBRE_MARCA + ' (' + CAST(DE.CANTIDAD AS VARCHAR) + ')', ', ') AS PRODUCTOS,
		  IE.DESCRIPCION
	FROM INVENTARIO_ENTRADAS IE
	INNER JOIN DETALLE_ENTRADA DE ON IE.ID_ENTRADA = DE.ID_ENTRADA
	INNER JOIN PRODUCTOS P ON P.ID_PRODUCTO = DE.ID_PRODUCTO
	INNER JOIN MARCAS M ON M.ID_MARCA = P.ID_MARCA
	GROUP BY IE.NUMERO_ENTRADA, IE.DESCRIPCION, IE.FECHA_ENTRADA
	ORDER BY NUMERO_ENTRADA DESC

END
GO

--PROCEDIMEINTO PARA GUARDAR MARCA
CREATE OR ALTER PROCEDURE Us_AgregarMarca
@Codigo VARCHAR(8),
@Nombre_Marca VARCHAR(100)
AS
BEGIN
	INSERT INTO MARCAS (CODIGO_MARCA, NOMBRE_MARCA)
	VALUES(@Codigo,@Nombre_Marca)
END
GO

--PROCEDIMIENTO PARA ACTUALIZAR MARCA
CREATE OR ALTER PROCEDURE Us_ActualizarMarca
@Codigo VARCHAR(8),
@Nombre_Marca VARCHAR(100)
AS
BEGIN
	UPDATE MARCAS
	SET CODIGO_MARCA=@Codigo,
		NOMBRE_MARCA=@Nombre_Marca
	WHERE CODIGO_MARCA=@Codigo
END
GO

--PROCEDIMIENTO PARA LEER MARCA EN CASO DE ACTUALIZACION TAMBIEN PARA MOSTRAR EN EL CATALOGO SEGUN EL CODIGO
CREATE OR ALTER PROCEDURE Us_ReadMarca
@Codigo VARCHAR(8)
AS
BEGIN
	SELECT CODIGO_MARCA, NOMBRE_MARCA FROM MARCAS WHERE CODIGO_MARCA=@Codigo
END
GO

--PROCEDIMIENTO PARA MOSTRAR MASCAS SEGUN LA CANTIDAD DESEADA DE VISUALIZACIÓN
CREATE OR ALTER PROCEDURE Us_ReadTopMarcas
@ValuesTop int
AS
BEGIN
		SELECT TOP(@ValuesTop) CODIGO_MARCA, NOMBRE_MARCA FROM MARCAS
END
GO

--PROCEDIMEINTO PARA GUARDAR CATEGORIA
CREATE OR ALTER PROCEDURE Us_AgregarCategoria
@Codigo VARCHAR(10),
@Nombre_Categoria VARCHAR(100)
AS
BEGIN
	INSERT INTO CATEGORIAS(CODIGO_CATEGORIA, NOMBRE_CATEGORIA)
	VALUES(@Codigo,@Nombre_Categoria)
END
GO

--PROCEDIMIENTO PARA ACTUALIZAR CATEGORIA
CREATE OR ALTER PROCEDURE Us_ActualizarCategoria
@Codigo VARCHAR(10),
@Nombre_Categoria VARCHAR(100)
AS
BEGIN
	UPDATE CATEGORIAS
	SET CODIGO_CATEGORIA=@Codigo,
		NOMBRE_CATEGORIA=@Nombre_Categoria
	WHERE CODIGO_CATEGORIA=@Codigo
END
GO

--PROCEDIMIENTO PARA LEER CATEGORIA EN CASO DE ACTUALIZACION TAMBIEN PARA MOSTRAR EN EL CATALOGO SEGUN EL CODIGO
CREATE OR ALTER PROCEDURE Us_ReadCategoria
@Codigo VARCHAR(10)
AS
BEGIN
	SELECT CODIGO_CATEGORIA, NOMBRE_CATEGORIA FROM CATEGORIAS WHERE CODIGO_CATEGORIA=@Codigo
END
GO

--PROCEDIMIENTO PARA MOSTRAR CATEGORIA SEGUN LA CANTIDAD DESEADA DE VISUALIZACIÓN
CREATE OR ALTER PROCEDURE Us_ReadTopCategorias
@ValuesTop int
AS
BEGIN
		SELECT TOP(@ValuesTop) CODIGO_CATEGORIA, NOMBRE_CATEGORIA FROM CATEGORIAS
END
GO

--PROCEDIMIENTO PARA BUSCAR MARCA POR NOMBRE
CREATE OR ALTER  PROCEDURE Us_BuscaMarcaPorNombre
    @NOMBRE VARCHAR(100)
AS
BEGIN
    SELECT CODIGO_MARCA,NOMBRE_MARCA
    FROM MARCAS 
    WHERE NOMBRE_MARCA LIKE '%' + @NOMBRE + '%'	
END
GO

--PROCEDIMEINTO PARA BUSCAR CATEGORIA POR NOMBRE
CREATE OR ALTER  PROCEDURE Us_BuscaCategoriaPorNombre
    @NOMBRE VARCHAR(100)
AS
BEGIN
    SELECT CODIGO_CATEGORIA, NOMBRE_CATEGORIA
    FROM CATEGORIAS 
    WHERE NOMBRE_CATEGORIA LIKE '%' + @NOMBRE + '%'	
END
GO

--PROCEDIMIENTO PRA OBTENER EL ID DE LA TABLA CLIENTE
CREATE OR ALTER PROCEDURE Us_ObtenerIdCliente
AS
BEGIN
	SELECT ID_CLIENTE, CODIGO_CLIENTE
	FROM CLIENTES
END
GO

--PROCEDIMIENTO ALMACENADO PARA MOSTRAR DATOS DE LOS PRODUCTOS QUE SE MOSTRARAN AL MOMENTO DE REALIZAR UNA VENTA
CREATE OR ALTER PROCEDURE Us_MostrarProductos
AS
BEGIN
	SELECT P.CODIGO_PRODUCTO, P.NOMBRE_PRODUCT + ', ' + M.NOMBRE_MARCA + ', ' + C.NOMBRE_CATEGORIA AS PRODUCTO,P.CANTIDAD, P.PRECIO_PRODUCTO
	FROM PRODUCTOS P
	INNER JOIN MARCAS M
	ON M.ID_MARCA=P.ID_MARCA
	INNER JOIN CATEGORIAS C
	ON C.ID_CATEGORIA=P.ID_CATEGORIA
	ORDER BY ID_PRODUCTO DESC
END
GO

--PROCEDIMIENTO PARA AGREGAR DETALLES DE MANO DE OBRA, EN ESTE CASO SI SE REALIZA UNA VENTA
CREATE OR ALTER PROCEDURE Us_AgregarDetalleManoObra
@IdVenta int,
@IdTipo int,
@Descripcion VARCHAR(255),
@PrecioObra DECIMAL(10,2)
AS
BEGIN
	INSERT INTO DETALLE_MANO_OBRA(ID_VENTA, ID_TIPO_MANO_OBRA, DESCRIPCION, PRECIO_MANO_DE_OBRA)
	VALUES(@IdVenta, @IdTipo, @Descripcion, @PrecioObra)
END
GO

--PROCEDIMEINTO PARA AGREGAR UNA NUEVA VENTA
CREATE OR ALTER PROCEDURE Us_AgregarVenta
@Numero INT,
@IdCliente INT,
@FechaVenta DATETIME,
@MontoTotal DECIMAL(10,2),
@MetodoPago VARCHAR(50)
AS
BEGIN
	INSERT INTO VENTAS(NUMERO_VENTA, ID_CLIENTE, FECHA_VENTA, MONTO_TOTAL,METODO_PAGO, ESTADO)
	VALUES(@Numero, @IdCliente, @FechaVenta, @MontoTotal,@MetodoPago, 'REALIZADA')
END
GO

--PROCEDIMIENTO PARA ACTUALIZAR VENTA
CREATE OR ALTER PROCEDURE Us_ActualizarVenta
@Numero INT,
@IdCliente INT,
@FechaVenta DATETIME,
@MontoTotal DECIMAL(10,2),
@MetodoPago VARCHAR(50)
AS
BEGIN
	UPDATE VENTAS SET
	NUMERO_VENTA=@Numero,
	ID_CLIENTE= @IdCliente,
	FECHA_VENTA=@FechaVenta,
	MONTO_TOTAL=@MontoTotal,
	METODO_PAGO=@MetodoPago,
	ESTADO= 'REALIZADA'
	WHERE NUMERO_VENTA=@Numero
END
GO

--PROCEDIMIENTO PARA OBTENER EL ID DE VENTAS
CREATE OR ALTER PROCEDURE Us_ObtenerIdVenta
AS
BEGIN
	SELECT ID_VENTA, NUMERO_VENTA FROM VENTAS
END
GO

--PROCEDIMIENTO PARA LEER VENTAS DE ACUEDO AL NUMERO PARA ACTUALIZACIONES
CREATE OR ALTER PROCEDURE Us_ReadVenta
@Numero int
AS
BEGIN
	SELECT NUMERO_VENTA, ID_CLIENTE, FECHA_VENTA, MONTO_TOTAL,METODO_PAGO, ESTADO 
	FROM VENTAS
	WHERE NUMERO_VENTA=@Numero
END
GO

--PROCEDIMIENTO PARA ANULAR VENTA
CREATE OR ALTER PROCEDURE Us_AnularVenta
@Numero INT
AS
BEGIN
	UPDATE VENTAS SET ESTADO = 'ANULADA'
    WHERE NUMERO_VENTA = @Numero
END
GO

--POCEDIMIENTO PARA AGREGAR DETALLE DE LOS PRODUCTOS VENDIDOS
CREATE OR ALTER PROCEDURE Us_AgregarDetalleVenta
    @IdVenta int,
    @IdProducto int,
    @Cantidad DECIMAL(10,2),
    @PrecioUnitario DECIMAL(10,2),
    @SubTotal DECIMAL(10,2),
    @Descripcion VARCHAR(100)
AS
BEGIN
    -- Iniciar una transacción para asegurar la consistencia de los datos
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Insertar el detalle de la venta
        INSERT INTO DETALLE_VENTAS(ID_VENTA, ID_PRODUCTO, CANTIDAD, PRECIO_UNITARIO, SUBTOTAL, DESCRIPCION)
        VALUES(@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario, @SubTotal, @Descripcion);

        -- Actualizar la cantidad disponible del producto en la tabla de productos
        UPDATE PRODUCTOS
        SET @Cantidad=CANTIDAD = CANTIDAD - @Cantidad
        WHERE ID_PRODUCTO = @IdProducto;

        -- Verificar que la cantidad no se reduzca a un valor negativo
        IF (SELECT CANTIDAD FROM PRODUCTOS WHERE ID_PRODUCTO = @IdProducto) < 0
        BEGIN
            -- Si la cantidad es negativa, se revierte la transacción
            ROLLBACK TRANSACTION;
            RAISERROR('No hay suficiente cantidad en inventario para este producto.', 16, 1);
        END
        ELSE
        BEGIN
            -- Confirmar la transacción si todo está correcto
            COMMIT TRANSACTION;
        END
    END TRY
    BEGIN CATCH
        -- Si ocurre un error, se revierte la transacción
        ROLLBACK TRANSACTION;
        -- Se lanza un mensaje de error
        THROW;
    END CATCH;
END
GO

--PROCEDIMEINTO PARA OBTENER EL PROXIMO NUMERO DE VENTA
CREATE  OR ALTER PROCEDURE [dbo].[Us_ObtenerNumeroVenta]
AS
BEGIN
    DECLARE @SiguienteNumero INT;

    -- Obtener el próximo número de entrada
    SELECT @SiguienteNumero = ISNULL(MAX(NUMERO_VENTA), 0) + 1
    FROM VENTAS;

    -- Retornar el próximo número de factura de compra
    SELECT @SiguienteNumero AS NuevoNumero;
END
GO

--PROCEDIMEINTO PARA VERIFICAR LA CANTDAD DE PRODUCTOS DEL INVENTARIO PARA VER SI SE PUEDE REALIAR LA VENT 
CREATE OR ALTER PROCEDURE Us_ObtenerCantidadProducto
@Codigo varchar(10)
AS
BEGIN
    SELECT CANTIDAD
    FROM PRODUCTOS
    WHERE CODIGO_PRODUCTO = @Codigo
END
GO

--PRCEDIMIENTO PRA AGREGAR UN USUARIO PARA LOGIN
CREATE OR ALTER  PROCEDURE Us_AutenticacionUsuario
      @username VARCHAR(10),
    @password VARCHAR(12),
    @area VARCHAR(18)
AS
BEGIN
    SELECT COUNT(*)
    FROM USUARIOS
    WHERE USUARIO = @username
    AND CONTRASENA = @password
    AND ROL = @area
	AND ESTADO =1
END
GO

--PROCEDIMIENTO PARA AGREGAR UN NUEVO CLIENTE
CREATE OR ALTER PROCEDURE [dbo].[Us_AgregarCliente]
    @codigo CHAR(6),
    @nombres varchar(100),
    @apellidos varchar(100),
	@telefono varchar(20),
    @direccion VARCHAR(256)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Insertar un nuevo registro en la tabla Productos
        INSERT INTO CLIENTES(CODIGO_CLIENTE,NOMBRES, APELLIDOS,TELEFONO, DIRECCION, ESTADO)
        VALUES (@codigo, @nombres, @apellidos, @telefono, @direccion,1);
    END TRY
    BEGIN CATCH
        -- Manejo de errores
        THROW;
    END CATCH
END;
GO

--PROCEDIMIENTO PARA ACTUALIZAR CLIENTE
CREATE OR ALTER PROCEDURE [dbo].[Us_ActualizarCliente]
	@codigo CHAR(6),
    @nombres varchar(100),
    @apellidos varchar(100),
	@telefono varchar(20),
    @direccion VARCHAR(256)
AS
BEGIN
	UPDATE CLIENTES
	SET CODIGO_CLIENTE = @codigo,
		NOMBRES = @nombres,
		APELLIDOS = @apellidos,
		TELEFONO = @telefono,
		DIRECCION=@direccion
	WHERE CODIGO_CLIENTE = @codigo
END
GO

--PRCEDIMIENTO PARA LEER CLIENTE
CREATE OR ALTER PROCEDURE [dbo].[Us_ReadCliente]
	@codigo CHAR(6) 
AS
BEGIN
	SELECT CODIGO_CLIENTE,
		   NOMBRES,
		   APELLIDOS,
		   TELEFONO,
		   DIRECCION
	FROM CLIENTES
	WHERE CODIGO_CLIENTE = @codigo
	  AND Estado = 1 -- Solo clientes activos
END
GO

--PRCEDIMIENTO PARA MOSTRAR LA LISTA DE LOS CLIENTES EN UNA TABLA ELIGIENDO LA CANTIDAD
CREATE  OR ALTER PROCEDURE [dbo].[Us_ReadTopCliente] 
	@valuesTop int
	AS
	BEGIN
		-- Evitar la posible interferencia de un conjunto de registros en los resultados de Select
		SET NOCOUNT ON
		SELECT TOP (@valuesTop)
			   c.ID_CLIENTE,
			   c.CODIGO_CLIENTE,
			   c.NOMBRES,
			   c.APELLIDOS,
			   c.TELEFONO,
			   c.DIRECCION
		FROM CLIENTES c
		WHERE c.ESTADO = 1 
		ORDER BY ID_CLIENTE DESC
	END

GO

--PROCEDIMIENTO PARA BUSCAR CIENTES POR NOMBRES
CREATE OR ALTER  PROCEDURE Us_BuscarClientePorNombre
    @NOMBRE VARCHAR(100)
AS
BEGIN
    SELECT  CODIGO_CLIENTE, NOMBRES, APELLIDOS, TELEFONO, DIRECCION
    FROM CLIENTES
    WHERE NOMBRES LIKE '%' + @NOMBRE + '%'	
    OR APELLIDOS LIKE '%' + @NOMBRE + '%';
END
GO

--PROCEDIMIENTO PARA ELIMINAR UN OBJETO CLIENTE
CREATE OR ALTER  PROCEDURE [dbo].[Us_EliminarCliente]
    @codigo varchar(6)
AS
BEGIN
    UPDATE CLIENTES SET ESTADO = 0
    WHERE CODIGO_CLIENTE = @codigo
END
GO

--PROCEDIMIENTO PARA AGREGAR IN NUEVO USUARIO
CREATE OR ALTER PROCEDURE Us_AgregarUsurio
@Codigo CHAR(6),
@Rol VARCHAR(18),
@Nombres VARCHAR(100),
@Apellidos VARCHAR(100),
@Usuario VARCHAR(10),
@Contrasena VARCHAR(12)
AS
BEGIN
	INSERT INTO USUARIOS(CODIGO_USUARIO, ROL, NOMBRES, APELLIDOS, USUARIO, CONTRASENA, ESTADO)
	VALUES(@Codigo, @Rol,@Nombres, @Apellidos, @Usuario,@Contrasena,1)
END
GO

--PROCEDIMIENTO PARA ACTUALIZAR UN USUARIO
CREATE OR ALTER PROCEDURE Us_ActualizarUsuario
@Codigo CHAR(6),
@Rol VARCHAR(18),
@Nombres VARCHAR(100),
@Apellidos VARCHAR(100),
@Usuario VARCHAR(10),
@Contrasena VARCHAR(12)
AS
BEGIN
	UPDATE USUARIOS
	SET CODIGO_USUARIO= @Codigo,
		ROL=@Rol,
		NOMBRES=@Nombres,
		APELLIDOS=@Apellidos,
		USUARIO=@Usuario,
		CONTRASENA=@Contrasena,
		ESTADO=1
		WHERE CODIGO_USUARIO=@Codigo
END
GO

--PROCEDIMIENTO PARA LEER UN USUARIOEN CASO DE ACTUALIZACION CON UN CODIGO DE PARAMETRO ADEMAS PARA MOSTRAR EN LA TABLA AL BUSCAR POR EL MISMO
CREATE OR ALTER PROCEDURE Us_LeerUsuario
@Codigo CHAR(6)
AS
BEGIN
	SELECT CODIGO_USUARIO, NOMBRES, APELLIDOS, ROL, USUARIO, CONTRASENA
	FROM USUARIOS
	WHERE CODIGO_USUARIO=@Codigo
END
GO

--PRCEDIMIENTO PARA ELIMINAR UN USUARIO
CREATE OR ALTER PROCEDURE Us_EliminarUsuario
@Codigo CHAR(6)
AS
BEGIN
	UPDATE USUARIOS SET ESTADO = 0
    WHERE CODIGO_USUARIO = @Codigo
END
GO

--PRCEDIMIENTO PARA MOSTRAR LOS USUARIOS
CREATE OR ALTER PROCEDURE Us_MostrarUsuarios
AS
BEGIN
	SELECT CODIGO_USUARIO, NOMBRES, APELLIDOS, ROL, USUARIO, CONTRASENA, ESTADO
	FROM USUARIOS
	WHERE ESTADO=1
	ORDER BY ID_USUARIO DESC
END
GO

--PROCEDIMIENTO PRA CALCULAR INGRESOS TOTALES Y GANANCIAS EN CAJA
CREATE OR ALTER PROCEDURE [dbo].[Us_CalcularIngresosEnCaja]
    @FechaCalculo DATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IngresosPorVentas NUMERIC(10, 2);
    DECLARE @ProductosVendidos INT;
    DECLARE @Ganancias NUMERIC(10, 2);

    -- Calcular ingresos por ventas para la fecha especificada
    SELECT @IngresosPorVentas = ISNULL(SUM(V.MONTO_TOTAL), 0)
    FROM dbo.VENTAS V
    WHERE CONVERT(DATE, V.FECHA_VENTA) = @FechaCalculo;

    -- Calcular cantidad total de productos vendidos para la fecha especificada
    SELECT @ProductosVendidos = ISNULL(SUM(DFV.CANTIDAD), 0)
    FROM dbo.DETALLE_VENTAS DFV
    INNER JOIN dbo.VENTAS FV ON DFV.ID_VENTA = FV.ID_VENTA
    WHERE CONVERT(DATE, FV.FECHA_VENTA) = @FechaCalculo;

    -- Calcular ganancias totales basadas en los productos vendidos
    SELECT @Ganancias = ISNULL(SUM((DFV.PRECIO_UNITARIO - DE.PRECIO_ENTRADA) * DFV.CANTIDAD), 0)
    FROM dbo.DETALLE_VENTAS DFV
    INNER JOIN dbo.VENTAS FV ON DFV.ID_VENTA = FV.ID_VENTA
    INNER JOIN dbo.PRODUCTOS P ON DFV.ID_PRODUCTO = P.ID_PRODUCTO
    INNER JOIN (
        SELECT DE.ID_PRODUCTO, MAX(IE.FECHA_ENTRADA) AS FechaUltimaEntrada
        FROM dbo.DETALLE_ENTRADA DE
        INNER JOIN dbo.INVENTARIO_ENTRADAS IE ON DE.ID_ENTRADA = IE.ID_ENTRADA
        GROUP BY DE.ID_PRODUCTO
    ) UltimaEntrada ON P.ID_PRODUCTO = UltimaEntrada.ID_PRODUCTO
    INNER JOIN dbo.DETALLE_ENTRADA DE ON DE.ID_PRODUCTO = UltimaEntrada.ID_PRODUCTO 
    INNER JOIN dbo.INVENTARIO_ENTRADAS IE1 ON DE.ID_ENTRADA = IE1.ID_ENTRADA
    AND IE1.FECHA_ENTRADA = UltimaEntrada.FechaUltimaEntrada
    WHERE CONVERT(DATE, FV.FECHA_VENTA) = @FechaCalculo;

    -- Mostrar resultados
    SELECT 
        IngresosPorVentas = @IngresosPorVentas,
        ProductosVendidos = @ProductosVendidos,
        Ganancias = @Ganancias;
END
GO

--PROCEDIMIENTO DE LAS TENDENCIAS DE VENTAS
--ya
CREATE OR ALTER PROCEDURE Us_ReportTendenciasVentas 
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @AnioActual INT = YEAR(GETDATE()); -- Obtiene el año actual

    SELECT 
        MONTH(FECHA_VENTA) AS MesNumero,
        DATENAME(MONTH, FECHA_VENTA) AS NombreMes, -- Obtiene el nombre del mes
        SUM(MONTO_TOTAL) AS TotalVentas,
        COUNT(ID_VENTA) AS TotalVentasRealizadas
    FROM 
        dbo.VENTAS
    WHERE 
        YEAR(FECHA_VENTA) = @AnioActual AND ESTADO = 'REALIZADA' -- Filtra las ventas del año actual
    GROUP BY 
        MONTH(FECHA_VENTA), DATENAME(MONTH, FECHA_VENTA) -- Agrupa por mes
    ORDER BY 
        MesNumero; -- Ordena por número de mes
END
GO

--PROCEDIMEINTO PARA VER LOS MEJORES CLIENTES ELIGENDO LA CANTIDAD QUE SE DESEA VER PONIENDO AL MEJOR DE PRIMERO 
--YA
CREATE OR ALTER PROCEDURE Us_ReportMejoresClientes 
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 10
		C.CODIGO_CLIENTE +' - '+
        C.NOMBRES + ' '+
        C.APELLIDOS as CLIENTE,
        COUNT(V.ID_VENTA) AS TotalVentas,
        SUM(V.MONTO_TOTAL) AS MontoTotal
    FROM 
        CLIENTES C
    INNER JOIN 
        VENTAS V ON C.ID_CLIENTE = V.ID_CLIENTE
    WHERE 
        V.ESTADO = 'REALIZADA'
    GROUP BY 
        C.ID_CLIENTE, C.NOMBRES, C.APELLIDOS, C.CODIGO_CLIENTE
    ORDER BY 
        TotalVentas DESC
END
GO

--PROCEDIMIENO PARA VER LAS VENTAS REALIZADAS CON DETALLES CONCATENADOS ELIGIENDO UNA FECHA INICIO Y UNA FIN
--ya
CREATE OR ALTER PROCEDURE Us_ReportVentasProductosRealizadasConDetalles 
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        V.NUMERO_VENTA,
        CONCAT(C.CODIGO_CLIENTE, ' - ', C.NOMBRES, ' ', C.APELLIDOS) AS Cliente, -- Concatenar datos del cliente
        V.FECHA_VENTA,
        STRING_AGG(CONCAT(P.NOMBRE_PRODUCT, ' (Cant: ', DV.CANTIDAD, ', P.Unitario: ', DV.PRECIO_UNITARIO, ')'), ', ') AS DetallesProductos, -- Concatenar detalles de productos vendidos
        V.MONTO_TOTAL
    FROM 
        dbo.VENTAS V
    INNER JOIN 
        dbo.CLIENTES C ON V.ID_CLIENTE = C.ID_CLIENTE
    INNER JOIN 
        dbo.DETALLE_VENTAS DV ON V.ID_VENTA = DV.ID_VENTA
    INNER JOIN 
        dbo.PRODUCTOS P ON DV.ID_PRODUCTO = P.ID_PRODUCTO
    WHERE 
        V.FECHA_VENTA BETWEEN @FechaInicio AND @FechaFin -- Filtrar por rango de fechas
    GROUP BY 
        V.NUMERO_VENTA, C.CODIGO_CLIENTE, C.NOMBRES, C.APELLIDOS, V.FECHA_VENTA, V.MONTO_TOTAL
    ORDER BY 
        V.FECHA_VENTA DESC -- Ordenar por fecha de venta
END
GO

--PROCEDIMEINTO QUE MUESTRA LAS VENTAS DE MANO DE OBRA REALIZADAS
--ya
CREATE OR ALTER PROCEDURE Us_ReportVentasManoObraRealizadasConDetalles
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        V.NUMERO_VENTA,
        CONCAT(C.CODIGO_CLIENTE, ' - ', C.NOMBRES, ' ', C.APELLIDOS) AS Cliente,  -- Concatenar datos del cliente
        V.FECHA_VENTA,
        STRING_AGG(CONCAT(DMO.DESCRIPCION, ', Precio: ', DMO.PRECIO_MANO_DE_OBRA, ')'), ', ') AS DetallesManoObra, -- Concatenar detalles de la mano de obra
        V.MONTO_TOTAL
    FROM 
        dbo.VENTAS V
    INNER JOIN 
        dbo.CLIENTES C ON V.ID_CLIENTE = C.ID_CLIENTE
    INNER JOIN 
        dbo.DETALLE_MANO_OBRA DMO ON V.ID_VENTA = DMO.ID_VENTA
    WHERE 
        V.FECHA_VENTA BETWEEN @FechaInicio AND @FechaFin -- Filtrar por rango de fechas
    GROUP BY 
        V.NUMERO_VENTA, C.CODIGO_CLIENTE, C.NOMBRES, C.APELLIDOS, V.FECHA_VENTA, V.MONTO_TOTAL
    ORDER BY 
        V.FECHA_VENTA DESC; -- Ordenar por fecha de venta
END
GO


--PROCEDIMIENTO PARA VER TODAS LAS VENTAS REALIZAAS
--ya
CREATE OR ALTER PROCEDURE Us_ReportVentasRealizadasConDetalles
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    -- Usamos CTEs para crear las columnas de detalles con mensajes adecuados solo cuando existen registros
    WITH DetallesProductos AS (
        SELECT 
            V.ID_VENTA,
            CASE 
                WHEN COUNT(DV.ID_VENTA) > 0 
                THEN STRING_AGG(CONCAT(P.NOMBRE_PRODUCT, ' (Cant: ', DV.CANTIDAD, ', P.Unitario: ', DV.PRECIO_UNITARIO, ')'), ', ') 
                ELSE 'NO EXISTEN DETALLES'
            END AS Detalles
        FROM 
            dbo.VENTAS V
        LEFT JOIN 
            dbo.DETALLE_VENTAS DV ON V.ID_VENTA = DV.ID_VENTA
        LEFT JOIN 
            dbo.PRODUCTOS P ON DV.ID_PRODUCTO = P.ID_PRODUCTO
        GROUP BY 
            V.ID_VENTA
    ),
    DetallesManoObra AS (
        SELECT 
            V.ID_VENTA,
            CASE 
                WHEN COUNT(DMO.ID_VENTA) > 0 
                THEN STRING_AGG(CONCAT(DMO.DESCRIPCION, ' (Precio: ', DMO.PRECIO_MANO_DE_OBRA, ')'), ', ')
                ELSE 'NO EXISTEN DETALLES'
            END AS Detalles
        FROM 
            dbo.VENTAS V
        LEFT JOIN 
            dbo.DETALLE_MANO_OBRA DMO ON V.ID_VENTA = DMO.ID_VENTA
        GROUP BY 
            V.ID_VENTA
    )

    SELECT 
        V.NUMERO_VENTA,
        CONCAT(C.CODIGO_CLIENTE, ' - ', C.NOMBRES, ' ', C.APELLIDOS) AS Cliente,
        V.FECHA_VENTA,
        DP.Detalles AS DetallesProductos,
        DMO.Detalles AS DetallesManoObra,
        V.MONTO_TOTAL
    FROM 
        dbo.VENTAS V
    INNER JOIN 
        dbo.CLIENTES C ON V.ID_CLIENTE = C.ID_CLIENTE
    LEFT JOIN 
        DetallesProductos DP ON V.ID_VENTA = DP.ID_VENTA
    LEFT JOIN 
        DetallesManoObra DMO ON V.ID_VENTA = DMO.ID_VENTA
    WHERE 
        V.FECHA_VENTA BETWEEN @FechaInicio AND @FechaFin
    ORDER BY 
        V.FECHA_VENTA DESC;
END
GO


--PRCEDIMIENTO PARA VER LAS ENTRADAS REALIZADAS DADA UNA CANTIDAD 
CREATE OR ALTER PROCEDURE Us_ReportEntradasRealizadas 
    @CantidadMinima INT -- Parámetro para filtrar por cantidad mínima de productos
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        IE.NUMERO_ENTRADA,               -- Número de entrada
        IE.FECHA_ENTRADA,                -- Fecha de entrada
        STRING_AGG(CONCAT(P.NOMBRE_PRODUCT, ' (Cantidad: ', DE.CANTIDAD, ', Precio: ', DE.PRECIO_ENTRADA, ')'), ', ') AS ProductosQueEntraron -- Concatenación de productos
    FROM 
        dbo.INVENTARIO_ENTRADAS IE
    INNER JOIN 
        dbo.DETALLE_ENTRADA DE ON IE.ID_ENTRADA = DE.ID_ENTRADA
    INNER JOIN 
        dbo.PRODUCTOS P ON DE.ID_PRODUCTO = P.ID_PRODUCTO
    GROUP BY 
        IE.NUMERO_ENTRADA,               -- Agrupa por número de entrada
        IE.FECHA_ENTRADA                 -- Agrupa por fecha de entrada
    ORDER BY 
        IE.FECHA_ENTRADA DESC        -- Ordena por fecha de entrada
	OFFSET 0 ROWS FETCH NEXT @CantidadMinima ROWS ONLY; -- Usa la variable @Cantidad aquí
END
GO

--PROCEDIMEINTO QEU MUESTRA LOS PRODUCTOS MAS VENDIDOS
--ya
CREATE OR ALTER PROCEDURE Us_ReportTop10ProductosMasVendidos
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        CONCAT(P.NOMBRE_PRODUCT, ', ' , M.NOMBRE_MARCA, ', ' , C.NOMBRE_CATEGORIA) AS Producto, -- Producto con marca y categoría
        SUM(DV.CANTIDAD) AS TotalVendido,           -- Cantidad total vendida
        SUM(DV.CANTIDAD * DV.PRECIO_UNITARIO) AS TotalIngresos -- Ingresos generados por el producto
    FROM 
        dbo.DETALLE_VENTAS DV
    INNER JOIN 
        dbo.PRODUCTOS P ON DV.ID_PRODUCTO = P.ID_PRODUCTO
    INNER JOIN 
        dbo.MARCAS M ON M.ID_MARCA = P.ID_MARCA
    INNER JOIN 
        dbo.CATEGORIAS C ON C.ID_CATEGORIA = P.ID_CATEGORIA
    GROUP BY 
        P.NOMBRE_PRODUCT,                            -- Agrupa por nombre del producto
        M.NOMBRE_MARCA,                              -- Agrupa por marca del producto
        C.NOMBRE_CATEGORIA                           -- Agrupa por categoría del producto
    ORDER BY 
        TotalVendido DESC                            -- Ordena por la cantidad total vendida en orden descendente
    OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY;           -- Limita la salida a los 10 productos más vendidos
END
GO

-- Procedimiento almacenado que guarda los resultados en variables
CREATE OR ALTER PROCEDURE ObtenerInformacionDeInventarioTotal
AS
BEGIN
    -- Declaración de variables para guardar los resultados
    DECLARE @inversion_total DECIMAL(18, 2);
    DECLARE @cantidad_total DECIMAL(18, 2);
    DECLARE @ganancia_esperada DECIMAL(18, 2);

    -- Calcular y asignar los valores a las variables
    SELECT 
        -- Inversión total: Calcula la inversión total de los productos activos, usando el precio de entrada de la tabla DETALLE_ENTRADA y la cantidad de la tabla PRODUCTOS
        @inversion_total = SUM(p.CANTIDAD * de.PRECIO_ENTRADA),

        -- Cantidad total: Tomamos la cantidad de productos que están registrados en la tabla PRODUCTOS
        @cantidad_total = SUM(p.CANTIDAD),

        -- Ganancia esperada: Calcula la ganancia esperada, tomando la diferencia entre el precio de venta y el precio de entrada de la tabla DETALLE_ENTRADA
        @ganancia_esperada = SUM((de.PRECIO_VENTA - de.PRECIO_ENTRADA) * p.CANTIDAD)
    FROM 
        PRODUCTOS p
    JOIN 
        DETALLE_ENTRADA de ON p.ID_PRODUCTO = de.ID_PRODUCTO
    

    -- Retornar los resultados almacenados en las variables
    SELECT 
        @inversion_total AS inversion_total,
        @cantidad_total AS cantidad_total,
        @ganancia_esperada AS ganancia_esperada;
END

GO


USE TALLER_FRANC
GO

INSERT INTO USUARIOS(CODIGO_USUARIO,ROL, NOMBRES, APELLIDOS, USUARIO, CONTRASENA, ESTADO)
VALUES('US001','Administrador', 'ADMINISTRADOR','   ','admin','1234',1)

--PARA TENER DEFINIDO YA EL CLIENTE GENETICO
INSERT INTO CLIENTES(CODIGO_CLIENTE, NOMBRES, APELLIDOS, ESTADO)
VALUES('GEN001', 'CLIENTE', 'VARIOS',1)
GO

--PARA TENER LISTO LOS PRODUCTOS SIN CATEGORIA Y LOS PRODUCTOS SIN MARCA
INSERT INTO CATEGORIAS(CODIGO_CATEGORIA,NOMBRE_CATEGORIA)
VALUES ('NOTCA001', '     ')
GO
INSERT INTO MARCAS(CODIGO_MARCA, NOMBRE_MARCA)
VALUES('NOTMA001', '    ')
GO

--CREAR EL TIPO DE LAS MANO DE OBRAS
INSERT INTO TIPO_MANO_OBRA (NOMBRE_TIPO)
VALUES 
    ('Mecánica'),
    ('Eléctrica'),
    ('Pintura');

USE master
go
-- Crear el login a nivel de servidor
CREATE LOGIN FRANc WITH PASSWORD = 'CzMa7p*0';
GO

USE TALLER_FRANC;
GO
-- Crear el usuario en la base de datos
CREATE USER FRANc FOR LOGIN FRANc;
GO

-- Asignar roles a este usuario
ALTER ROLE db_datareader ADD MEMBER FRANc;
go
ALTER ROLE db_datawriter ADD MEMBER FRANc;
go
ALTER ROLE db_owner ADD MEMBER FRANc;
GO
CREATE OR ALTER PROCEDURE [dbo].[EliminarDetalleVenta]
    @NumeroVenta INT,         -- Número de venta
    @CodigoProducto VARCHAR(10)  -- Código del producto
AS
BEGIN
    DECLARE @CantidadEliminada DECIMAL(10, 2);
    DECLARE @IDProducto INT;
    DECLARE @Subtotal DECIMAL(10, 2);

    BEGIN TRY
        -- 1. Obtener el ID del producto desde el código
        SELECT @IDProducto = ID_PRODUCTO
        FROM PRODUCTOS
        WHERE CODIGO_PRODUCTO = @CodigoProducto;

        -- Verificar si el producto existe
        IF @IDProducto IS NULL
        BEGIN
            PRINT 'Producto no encontrado con el código proporcionado.';
            RETURN;
        END

        -- 2. Obtener la cantidad del detalle de venta que se va a eliminar
        SELECT @CantidadEliminada = DV.CANTIDAD
        FROM DETALLE_VENTAS DV
        INNER JOIN VENTAS V ON V.ID_VENTA = DV.ID_VENTA
        WHERE V.NUMERO_VENTA = @NumeroVenta AND DV.ID_PRODUCTO = @IDProducto;

        -- Verificar si se encontró la cantidad a eliminar
        IF @CantidadEliminada IS NULL
        BEGIN
            PRINT 'No se encontró el detalle de venta con ese número de venta y código de producto.';
            RETURN;
        END

        -- 3. Obtener el subtotal del detalle de venta a eliminar
        SELECT @Subtotal = DV.SUBTOTAL
        FROM DETALLE_VENTAS DV
        INNER JOIN VENTAS V ON V.ID_VENTA = DV.ID_VENTA
        WHERE V.NUMERO_VENTA = @NumeroVenta AND DV.ID_PRODUCTO = @IDProducto;

        -- Verificar si el subtotal fue obtenido correctamente
        IF @Subtotal IS NULL
        BEGIN
            PRINT 'No se encontró el subtotal del detalle de venta a eliminar.';
            RETURN;
        END

        -- 4. Actualizar la cantidad en la tabla PRODUCTOS, sumando la cantidad eliminada
        UPDATE PRODUCTOS
        SET CANTIDAD = CANTIDAD + @CantidadEliminada
        WHERE ID_PRODUCTO = @IDProducto;

        -- 5. Eliminar el detalle de venta de la tabla DETALLE_VENTAS
        DELETE DV
        FROM DETALLE_VENTAS DV
        INNER JOIN VENTAS V ON V.ID_VENTA = DV.ID_VENTA
        WHERE V.NUMERO_VENTA = @NumeroVenta AND DV.ID_PRODUCTO = @IDProducto;

        -- 6. Actualizar el monto total de la venta, restando el subtotal eliminado
        UPDATE VENTAS
        SET MONTO_TOTAL = MONTO_TOTAL - @Subtotal
        WHERE NUMERO_VENTA = @NumeroVenta;

        -- Confirmación de eliminación
        PRINT 'Detalle de venta eliminado correctamente.';

    END TRY
    BEGIN CATCH
        -- Manejo de errores: en caso de fallo, devolver el mensaje de error
        PRINT 'Error al eliminar el detalle de venta: ' + ERROR_MESSAGE();
    END CATCH
END

 

