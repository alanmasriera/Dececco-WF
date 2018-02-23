USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Producto_Insert]
    @id_producto    int  output,
    @nombre_producto    varchar  (50),
    @descripcion    varchar  (500),
    @abreviatura    varchar  (50),
    @ubicacion    varchar  (50),
    @pack    decimal  (18,2),
    @stock_ideal    decimal  (18,2),
    @stock_minimo    decimal  (18,2),
    @cantidad_compra    decimal  (18,2),
    @cantidad_ingreso    decimal  (18,2),
    @id_subtipo_producto    int  ,
    @id_marca    int  ,
    @id_unidad    int  ,
    @tilde    bit  ,
    @tipo_venta    char  (1)
AS

INSERT INTO [dbo].[Producto]
(
    [nombre_producto],
    [descripcion],
    [abreviatura],
    [ubicacion],
    [pack],
    [stock_ideal],
    [stock_minimo],
    [cantidad_compra],
    [cantidad_ingreso],
    [id_subtipo_producto],
    [id_marca],
    [id_unidad],
    [tilde],
    [tipo_venta]
)
VALUES
(
    @nombre_producto,
    @descripcion,
    @abreviatura,
    @ubicacion,
    @pack,
    @stock_ideal,
    @stock_minimo,
    @cantidad_compra,
    @cantidad_ingreso,
    @id_subtipo_producto,
    @id_marca,
    @id_unidad,
    @tilde,
    @tipo_venta
)
SET @id_producto = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Producto_Delete]
    @id_producto    int
AS

DELETE FROM [dbo].[Producto]
WHERE
    [id_producto]  =  @id_producto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Producto_GetAll]
AS

SELECT TOP 100
    [id_producto] AS [Id producto] ,
    RTRIM(nombre_producto) AS [Nombre producto] ,
    RTRIM(descripcion) AS [Descripcion] ,
    RTRIM(abreviatura) AS [Abreviatura] ,
    RTRIM(ubicacion) AS [Ubicacion] ,
    [pack] AS [Pack] ,
    [stock_ideal] AS [Stock ideal] ,
    [stock_minimo] AS [Stock minimo] ,
    [cantidad_compra] AS [Cantidad compra] ,
    [cantidad_ingreso] AS [Cantidad ingreso] ,
    [id_subtipo_producto] AS [Id subtipo producto] ,
    [id_marca] AS [Id marca] ,
    [id_unidad] AS [Id unidad] ,
    [tilde] AS [Tilde] ,
    [tipo_venta] AS [Tipo venta]
FROM
    [dbo].[Producto]
ORDER BY
    [nombre_producto]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Producto_GetCmb]
AS

SELECT
    [id_producto],
    [nombre_producto],
    [descripcion],
    [abreviatura],
    [ubicacion],
    [pack],
    [stock_ideal],
    [stock_minimo],
    [cantidad_compra],
    [cantidad_ingreso],
    [id_subtipo_producto],
    [id_marca],
    [id_unidad],
    [tilde],
    [tipo_venta]
FROM
    [dbo].[Producto]
ORDER BY
    [nombre_producto]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_Update]
GO

CREATE PROCEDURE [dbo].[cop_Producto_Update]
    @id_producto    int  output,
    @nombre_producto    varchar  (50),
    @descripcion    varchar  (500),
    @abreviatura    varchar  (50),
    @ubicacion    varchar  (50),
    @pack    decimal  (18,2),
    @stock_ideal    decimal  (18,2),
    @stock_minimo    decimal  (18,2),
    @cantidad_compra    decimal  (18,2),
    @cantidad_ingreso    decimal  (18,2),
    @id_subtipo_producto    int  ,
    @id_marca    int  ,
    @id_unidad    int  ,
    @tilde    bit  ,
    @tipo_venta    char  (1)
AS

UPDATE [dbo].[Producto] SET
    [nombre_producto] = @nombre_producto,
    [descripcion] = @descripcion,
    [abreviatura] = @abreviatura,
    [ubicacion] = @ubicacion,
    [pack] = @pack,
    [stock_ideal] = @stock_ideal,
    [stock_minimo] = @stock_minimo,
    [cantidad_compra] = @cantidad_compra,
    [cantidad_ingreso] = @cantidad_ingreso,
    [id_subtipo_producto] = @id_subtipo_producto,
    [id_marca] = @id_marca,
    [id_unidad] = @id_unidad,
    [tilde] = @tilde,
    [tipo_venta] = @tipo_venta
WHERE
    [id_producto]  =  @id_producto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Producto_Exist]
    @nombre_producto    varchar  (50),
    @descripcion    varchar  (500),
    @abreviatura    varchar  (50),
    @ubicacion    varchar  (50),
    @pack    decimal  (18,2),
    @stock_ideal    decimal  (18,2),
    @stock_minimo    decimal  (18,2),
    @cantidad_compra    decimal  (18,2),
    @cantidad_ingreso    decimal  (18,2),
    @id_subtipo_producto    int  ,
    @id_marca    int  ,
    @id_unidad    int  ,
    @tilde    bit  ,
    @tipo_venta    char  (1)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_producto
FROM
    [dbo].[Producto]
WHERE
    [nombre_producto] = @nombre_producto AND
    [descripcion] = @descripcion AND
    [abreviatura] = @abreviatura AND
    [ubicacion] = @ubicacion AND
    [pack] = @pack AND
    [stock_ideal] = @stock_ideal AND
    [stock_minimo] = @stock_minimo AND
    [cantidad_compra] = @cantidad_compra AND
    [cantidad_ingreso] = @cantidad_ingreso AND
    [id_subtipo_producto] = @id_subtipo_producto AND
    [id_marca] = @id_marca AND
    [id_unidad] = @id_unidad AND
    [tilde] = @tilde AND
    [tipo_venta] = @tipo_venta

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Producto_GetOne]
    @id_producto    int
AS

SELECT
    [id_producto] AS [Id producto] ,
    [nombre_producto] AS [Nombre producto] ,
    [descripcion] AS [Descripcion] ,
    [abreviatura] AS [Abreviatura] ,
    [ubicacion] AS [Ubicacion] ,
    [pack] AS [Pack] ,
    [stock_ideal] AS [Stock ideal] ,
    [stock_minimo] AS [Stock minimo] ,
    [cantidad_compra] AS [Cantidad compra] ,
    [cantidad_ingreso] AS [Cantidad ingreso] ,
    [id_subtipo_producto] AS [Id subtipo producto] ,
    [id_marca] AS [Id marca] ,
    [id_unidad] AS [Id unidad] ,
    [tilde] AS [Tilde] ,
    [tipo_venta] AS [Tipo venta]
FROM
    [dbo].[Producto]
WHERE
    [id_producto]  =  @id_producto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_Find]
GO

CREATE PROCEDURE [dbo].[cop_Producto_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_producto] AS [Id producto] ,
    RTRIM(nombre_producto) AS [Nombre producto] ,
    RTRIM(descripcion) AS [Descripcion] ,
    RTRIM(abreviatura) AS [Abreviatura] ,
    RTRIM(ubicacion) AS [Ubicacion] ,
    [pack] AS [Pack] ,
    [stock_ideal] AS [Stock ideal] ,
    [stock_minimo] AS [Stock minimo] ,
    [cantidad_compra] AS [Cantidad compra] ,
    [cantidad_ingreso] AS [Cantidad ingreso] ,
    [id_subtipo_producto] AS [Id subtipo producto] ,
    [id_marca] AS [Id marca] ,
    [id_unidad] AS [Id unidad] ,
    [tilde] AS [Tilde] ,
    [tipo_venta] AS [Tipo venta]
FROM
    [dbo].[Producto]
WHERE
    [nombre_producto] LIKE @nombre+'%'
ORDER BY
    [nombre_producto]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Producto_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Producto_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Producto_InsertOne]
AS

INSERT INTO [dbo].[Producto]
(
    [nombre_producto],
    [descripcion],
    [abreviatura],
    [ubicacion],
    [pack],
    [stock_ideal],
    [stock_minimo],
    [cantidad_compra],
    [cantidad_ingreso],
    [id_subtipo_producto],
    [id_marca],
    [id_unidad],
    [tilde],
    [tipo_venta]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    0,
    0,
    0,
    0,
    0,
    1,
    1,
    1,
    0,
    ''
)
GO

