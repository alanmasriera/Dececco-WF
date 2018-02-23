USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Insert]
    @id_temp_grilla_pago_cliente    int  output,
    @id_pago_cliente    int  ,
    @fecha    datetime  ,
    @apellido    varchar  (50),
    @nombre    varchar  (50),
    @pago    decimal  (18,2),
    @detalle    varchar  (5000),
    @numero_recibo    varchar  (50),
    @observacion    varchar  (5000),
    @numero_orden_compra    varchar  (50)
AS

INSERT INTO [dbo].[Temp_grilla_pago_cliente]
(
    [id_pago_cliente],
    [fecha],
    [apellido],
    [nombre],
    [pago],
    [detalle],
    [numero_recibo],
    [observacion],
    [numero_orden_compra]
)
VALUES
(
    @id_pago_cliente,
    @fecha,
    @apellido,
    @nombre,
    @pago,
    @detalle,
    @numero_recibo,
    @observacion,
    @numero_orden_compra
)
SET @id_temp_grilla_pago_cliente = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Delete]
    @id_temp_grilla_pago_cliente    int
AS

DELETE FROM [dbo].[Temp_grilla_pago_cliente]
WHERE
    [id_temp_grilla_pago_cliente]  =  @id_temp_grilla_pago_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_GetAll]
AS

SELECT TOP 100
    [id_temp_grilla_pago_cliente] AS [Id temp grilla pago cliente] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [fecha] AS [Fecha] ,
    RTRIM(apellido) AS [Apellido] ,
    RTRIM(nombre) AS [Nombre] ,
    [pago] AS [Pago] ,
    RTRIM(detalle) AS [Detalle] ,
    RTRIM(numero_recibo) AS [Numero recibo] ,
    RTRIM(observacion) AS [Observacion] ,
    RTRIM(numero_orden_compra) AS [Numero orden compra]
FROM
    [dbo].[Temp_grilla_pago_cliente]
ORDER BY
    [id_pago_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_GetCmb]
AS

SELECT
    [id_temp_grilla_pago_cliente],
    [id_pago_cliente],
    [fecha],
    [apellido],
    [nombre],
    [pago],
    [detalle],
    [numero_recibo],
    [observacion],
    [numero_orden_compra]
FROM
    [dbo].[Temp_grilla_pago_cliente]
ORDER BY
    [id_pago_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Update]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Update]
    @id_temp_grilla_pago_cliente    int  output,
    @id_pago_cliente    int  ,
    @fecha    datetime  ,
    @apellido    varchar  (50),
    @nombre    varchar  (50),
    @pago    decimal  (18,2),
    @detalle    varchar  (5000),
    @numero_recibo    varchar  (50),
    @observacion    varchar  (5000),
    @numero_orden_compra    varchar  (50)
AS

UPDATE [dbo].[Temp_grilla_pago_cliente] SET
    [id_pago_cliente] = @id_pago_cliente,
    [fecha] = @fecha,
    [apellido] = @apellido,
    [nombre] = @nombre,
    [pago] = @pago,
    [detalle] = @detalle,
    [numero_recibo] = @numero_recibo,
    [observacion] = @observacion,
    [numero_orden_compra] = @numero_orden_compra
WHERE
    [id_temp_grilla_pago_cliente]  =  @id_temp_grilla_pago_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Exist]
    @id_pago_cliente    int  ,
    @fecha    datetime  ,
    @apellido    varchar  (50),
    @nombre    varchar  (50),
    @pago    decimal  (18,2),
    @detalle    varchar  (5000),
    @numero_recibo    varchar  (50),
    @observacion    varchar  (5000),
    @numero_orden_compra    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_temp_grilla_pago_cliente
FROM
    [dbo].[Temp_grilla_pago_cliente]
WHERE
    [id_pago_cliente] = @id_pago_cliente AND
    [fecha] = @fecha AND
    [apellido] = @apellido AND
    [nombre] = @nombre AND
    [pago] = @pago AND
    [detalle] = @detalle AND
    [numero_recibo] = @numero_recibo AND
    [observacion] = @observacion AND
    [numero_orden_compra] = @numero_orden_compra

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_GetOne]
    @id_temp_grilla_pago_cliente    int
AS

SELECT
    [id_temp_grilla_pago_cliente] AS [Id temp grilla pago cliente] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [fecha] AS [Fecha] ,
    [apellido] AS [Apellido] ,
    [nombre] AS [Nombre] ,
    [pago] AS [Pago] ,
    [detalle] AS [Detalle] ,
    [numero_recibo] AS [Numero recibo] ,
    [observacion] AS [Observacion] ,
    [numero_orden_compra] AS [Numero orden compra]
FROM
    [dbo].[Temp_grilla_pago_cliente]
WHERE
    [id_temp_grilla_pago_cliente]  =  @id_temp_grilla_pago_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Find]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_temp_grilla_pago_cliente] AS [Id temp grilla pago cliente] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [fecha] AS [Fecha] ,
    RTRIM(apellido) AS [Apellido] ,
    RTRIM(nombre) AS [Nombre] ,
    [pago] AS [Pago] ,
    RTRIM(detalle) AS [Detalle] ,
    RTRIM(numero_recibo) AS [Numero recibo] ,
    RTRIM(observacion) AS [Observacion] ,
    RTRIM(numero_orden_compra) AS [Numero orden compra]
FROM
    [dbo].[Temp_grilla_pago_cliente]
WHERE
    [id_pago_cliente] LIKE @nombre+'%'
ORDER BY
    [id_pago_cliente]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_grilla_pago_cliente_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Temp_grilla_pago_cliente_InsertOne]
AS

INSERT INTO [dbo].[Temp_grilla_pago_cliente]
(
    [id_pago_cliente],
    [fecha],
    [apellido],
    [nombre],
    [pago],
    [detalle],
    [numero_recibo],
    [observacion],
    [numero_orden_compra]
)
VALUES
(
    1,
    '01-01-2000',
    'Ninguno',
    'Ninguno',
    0,
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno'
)
GO

