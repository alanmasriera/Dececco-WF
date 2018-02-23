USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Remito_Insert]
    @id_remito    int  output,
    @id_factura    int  ,
    @fecha_remito    datetime  ,
    @numero_remito    varchar  (50),
    @id_cliente    int  ,
    @observacion    varchar  (5000),
    @id_condicion_venta    int  ,
    @id_usuario    int  
AS

INSERT INTO [dbo].[Remito]
(
    [id_factura],
    [fecha_remito],
    [numero_remito],
    [id_cliente],
    [observacion],
    [id_condicion_venta],
    [id_usuario]
)
VALUES
(
    @id_factura,
    @fecha_remito,
    @numero_remito,
    @id_cliente,
    @observacion,
    @id_condicion_venta,
    @id_usuario
)
SET @id_remito = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Remito_Delete]
    @id_remito    int
AS

DELETE FROM [dbo].[Remito]
WHERE
    [id_remito]  =  @id_remito
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Remito_GetAll]
AS

SELECT TOP 100
    [id_remito] AS [Id remito] ,
    [id_factura] AS [Id factura] ,
    [fecha_remito] AS [Fecha remito] ,
    RTRIM(numero_remito) AS [Numero remito] ,
    [id_cliente] AS [Id cliente] ,
    RTRIM(observacion) AS [Observacion] ,
    [id_condicion_venta] AS [Id condicion venta] ,
    [id_usuario] AS [Id usuario]
FROM
    [dbo].[Remito]
ORDER BY
    [id_factura]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Remito_GetCmb]
AS

SELECT
    [id_remito],
    [id_factura],
    [fecha_remito],
    [numero_remito],
    [id_cliente],
    [observacion],
    [id_condicion_venta],
    [id_usuario]
FROM
    [dbo].[Remito]
ORDER BY
    [id_factura]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_Update]
GO

CREATE PROCEDURE [dbo].[cop_Remito_Update]
    @id_remito    int  output,
    @id_factura    int  ,
    @fecha_remito    datetime  ,
    @numero_remito    varchar  (50),
    @id_cliente    int  ,
    @observacion    varchar  (5000),
    @id_condicion_venta    int  ,
    @id_usuario    int  
AS

UPDATE [dbo].[Remito] SET
    [id_factura] = @id_factura,
    [fecha_remito] = @fecha_remito,
    [numero_remito] = @numero_remito,
    [id_cliente] = @id_cliente,
    [observacion] = @observacion,
    [id_condicion_venta] = @id_condicion_venta,
    [id_usuario] = @id_usuario
WHERE
    [id_remito]  =  @id_remito
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Remito_Exist]
    @id_factura    int  ,
    @fecha_remito    datetime  ,
    @numero_remito    varchar  (50),
    @id_cliente    int  ,
    @observacion    varchar  (5000),
    @id_condicion_venta    int  ,
    @id_usuario    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_remito
FROM
    [dbo].[Remito]
WHERE
    [id_factura] = @id_factura AND
    [fecha_remito] = @fecha_remito AND
    [numero_remito] = @numero_remito AND
    [id_cliente] = @id_cliente AND
    [observacion] = @observacion AND
    [id_condicion_venta] = @id_condicion_venta AND
    [id_usuario] = @id_usuario

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Remito_GetOne]
    @id_remito    int
AS

SELECT
    [id_remito] AS [Id remito] ,
    [id_factura] AS [Id factura] ,
    [fecha_remito] AS [Fecha remito] ,
    [numero_remito] AS [Numero remito] ,
    [id_cliente] AS [Id cliente] ,
    [observacion] AS [Observacion] ,
    [id_condicion_venta] AS [Id condicion venta] ,
    [id_usuario] AS [Id usuario]
FROM
    [dbo].[Remito]
WHERE
    [id_remito]  =  @id_remito
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_Find]
GO

CREATE PROCEDURE [dbo].[cop_Remito_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_remito] AS [Id remito] ,
    [id_factura] AS [Id factura] ,
    [fecha_remito] AS [Fecha remito] ,
    RTRIM(numero_remito) AS [Numero remito] ,
    [id_cliente] AS [Id cliente] ,
    RTRIM(observacion) AS [Observacion] ,
    [id_condicion_venta] AS [Id condicion venta] ,
    [id_usuario] AS [Id usuario]
FROM
    [dbo].[Remito]
WHERE
    [id_factura] LIKE @nombre+'%'
ORDER BY
    [id_factura]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Remito_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Remito_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Remito_InsertOne]
AS

INSERT INTO [dbo].[Remito]
(
    [id_factura],
    [fecha_remito],
    [numero_remito],
    [id_cliente],
    [observacion],
    [id_condicion_venta],
    [id_usuario]
)
VALUES
(
    1,
    '01-01-2000',
    'Ninguno',
    1,
    'Ninguno',
    1,
     1 
)
GO

